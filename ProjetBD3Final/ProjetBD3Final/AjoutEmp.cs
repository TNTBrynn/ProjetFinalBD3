using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Windows.Forms;

namespace ProjetBD3Final
{
    public partial class AjoutEmp : Form
    {
        public AjoutEmp()
        {
            InitializeComponent();
            this.Load += new EventHandler(EmployeeForm_Load);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            PopulateCombox();
        }

        private void PopulateCombox()
        {
            using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
            {
                var provinces = from province in db.Provinces
                                select province.Id;

                cbProvinces.DataSource = provinces.ToList();

                var typeEmploye = from type in db.TypesEmploye
                                  where type.No != 1
                                  select new { type.No, type.Description };

                cbType.DisplayMember = "Description";
                cbType.ValueMember = "No";
                cbType.DataSource = typeEmploye.ToList();
            }
        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);
        }

        private void AjoutEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Employes);
        }

        private void noTypeEmployeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            // Validate input fields
            string validationMessage;
            if (!ValidateFields(out validationMessage))
            {
                MessageBox.Show(validationMessage, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
            {
                db.Connection.Open();
                using (var transaction = db.Connection.BeginTransaction())
                {
                    try
                    {
                        db.Transaction = transaction;
                        // Get the next employee number
                        int nextNo = db.Employes.Max(emp => emp.No) + 1;

                        string phone = new string(tbTel.Text.Where(char.IsDigit).ToArray());
                        string cellphone = new string(tbCell.Text.Where(char.IsDigit).ToArray());

                        string input = tbCode.Text;
                        string result = input.Replace(" ", "");

                        // Create a new employee
                        var newEmployee = new Employes
                        {
                            No = nextNo,
                            MotDePasse = tbMdp.Text,
                            Nom = tbNom.Text,
                            Prenom = tbPrenom.Text,
                            Sexe = Convert.ToChar(tbSexe.Text),
                            Age = int.Parse(tbAge.Text),
                            NoCivique = int.Parse(tbNoCiv.Text),
                            Rue = tbRue.Text,
                            Ville = tbVille.Text,
                            IdProvince = cbProvinces.SelectedValue.ToString(),
                            CodePostal = result,
                            Telephone = phone,
                            Cellulaire = cellphone,
                            Courriel = tbCourriel.Text,
                            SalaireHoraire = decimal.Parse(tbSalaire.Text),
                            NoTypeEmploye = (int)cbType.SelectedValue,
                            Remarque = tbRemarque.Text
                        };

                        db.Employes.InsertOnSubmit(newEmployee);
                        db.SubmitChanges();

                        var servicesToAdd = new List<string>();
                        switch (newEmployee.NoTypeEmploye)
                        {
                            case 2:
                            case 3:
                                servicesToAdd.AddRange(new[] { "Magasin Pro Shop", "Restaurant", "Leçon de golf" });
                                break;
                            case 5:
                                servicesToAdd.Add("Magasin Pro Shop");
                                break;
                            case 6:
                                servicesToAdd.Add("Restaurant");
                                break;
                            case 7:
                                servicesToAdd.Add("Leçon de golf");
                                break;
                        }

                        int nextServiceNo = db.Services.Any() ? db.Services.Max(s => s.No) + 1 : 1;

                        foreach (var service in servicesToAdd)
                        {
                            var serviceEntity = new Services
                            {
                                No = nextServiceNo++,
                                NoEmploye = newEmployee.No,
                                TypeService = service
                            };
                            db.Services.InsertOnSubmit(serviceEntity);
                        }

                        db.SubmitChanges();
                        transaction.Commit();
                        db.Connection.Close();
                        MessageBox.Show("Employé ajouté avec succès", "Confirmation d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de l'ajout de l'employé. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                    }
                }
            }
        }

        private bool ValidateFields(out string validationMessage)
        {
            // Validate tbMdp
            if (tbMdp.Text.Length < 8 || !tbMdp.Text.Any(char.IsLetter) || !tbMdp.Text.Any(char.IsDigit) || !tbMdp.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                validationMessage = "Le mot de passe doit comporter au moins 8 caractères et inclure des lettres, des chiffres et des caractères spéciaux.";
                return false;
            }

            // Validate tbNom
            if (!tbNom.Text.All(char.IsLetter))
            {
                validationMessage = "Le nom doit contenir uniquement des lettres.";
                return false;
            }

            // Validate tbPrenom
            if (!tbPrenom.Text.All(char.IsLetter))
            {
                validationMessage = "Le prénom doit contenir uniquement des lettres.";
                return false;
            }

            // Validate tbSexe
            if (tbSexe.Text.Length != 1 || (tbSexe.Text != "H" && tbSexe.Text != "F"))
            {
                validationMessage = "Le sexe doit être 'H' ou 'F'.";
                return false;
            }

            // Validate tbAge
            if (!int.TryParse(tbAge.Text, out int age) || age < 16 || age > 65)
            {
                validationMessage = "L'âge doit être un nombre entre 16 et 65.";
                return false;
            }

            // Validate tbNoCiv
            if (!int.TryParse(tbNoCiv.Text, out _))
            {
                validationMessage = "Le numéro civique doit être un nombre valide.";
                return false;
            }

            // Validate tbRue
            if (string.IsNullOrWhiteSpace(tbRue.Text))
            {
                validationMessage = "La rue ne peut pas être vide.";
                return false;
            }

            // Validate tbVille
            if (string.IsNullOrWhiteSpace(tbVille.Text))
            {
                validationMessage = "La ville ne peut pas être vide.";
                return false;
            }

            // Validate tbCode
            if (tbCode.Text.Length != 6)
            {
                validationMessage = "Le code postal doit comporter 6 caractères.";
                return false;
            }

            // Validate tbTel
            if (!Regex.IsMatch(tbTel.Text, @"^\(\d{3}\) \d{3}-\d{4}$"))
            {
                validationMessage = "Le numéro de téléphone doit être au format (123) 456-7890.";
                return false;
            }

            // Validate tbCell
            if (!Regex.IsMatch(tbCell.Text, @"^\(\d{3}\) \d{3}-\d{4}$"))
            {
                validationMessage = "Le numéro de téléphone cellulaire doit être au format (123) 456-7890.";
                return false;
            }

            // Validate tbCourriel
            if (!Regex.IsMatch(tbCourriel.Text, @"^[^@]+@[^@]+\.[^@]+$"))
            {
                validationMessage = "L'adresse courriel doit être une adresse valide.";
                return false;
            }

            // Validate tbSalaire
            if (!decimal.TryParse(tbSalaire.Text, out decimal salaire) || salaire < 15 || salaire > 500)
            {
                validationMessage = "Le salaire doit être un nombre entre 15 et 500.";
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }

        private void tbSalaire_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbProvince_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}