using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBD3Final
{
    public partial class ModifEmp : Form
    {
        private int employeeNo;
        public ModifEmp(int employeeNo)
        {
            InitializeComponent();
            this.employeeNo = employeeNo;
            this.Load += new EventHandler(ModifEmp_Load);
        }

        private void ModifEmp_Load(object sender, EventArgs e)
        {
            // Validate input fields
            

            using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
            {
                var employee = db.Employes.SingleOrDefault(emp => emp.No == employeeNo);
                if (employee != null)
                {
                    tbMdp.Text = employee.MotDePasse;
                    tbNom.Text = employee.Nom;
                    tbPrenom.Text = employee.Prenom;
                    tbSexe.Text = employee.Sexe.ToString();
                    tbAge.Text = employee.Age.ToString();
                    tbNoCiv.Text = employee.NoCivique.ToString();
                    tbRue.Text = employee.Rue;
                    tbVille.Text = employee.Ville;
                    tbProvince.Text = employee.IdProvince;
                    tbCode.Text = employee.CodePostal;
                    tbTel.Text = employee.Telephone;
                    tbCell.Text = employee.Cellulaire;
                    tbCourriel.Text = employee.Courriel;
                    tbSalaire.Text = employee.SalaireHoraire.ToString();
                    tbRemarque.Text = employee.Remarque;
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

            // Validate tbProvince
            string[] provinces = { "AB", "BC", "MB", "NB", "NL", "NS", "ON", "PE", "QC", "SK" };
            if (!provinces.Contains(tbProvince.Text))
            {
                validationMessage = "La province doit être l'une des suivantes : AB, BC, MB, NB, NL, NS, ON, PE, QC, SK.";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string validationMessage;
            if (!ValidateFields(out validationMessage))
            {
                MessageBox.Show(validationMessage, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
            {
                var employee = db.Employes.SingleOrDefault(emp => emp.No == employeeNo);
                if (employee != null)
                {
                    employee.MotDePasse = tbMdp.Text;
                    employee.Nom = tbNom.Text;
                    employee.Prenom = tbPrenom.Text;
                    employee.Sexe = Convert.ToChar(tbSexe.Text);
                    employee.Age = int.Parse(tbAge.Text);
                    employee.NoCivique = int.Parse(tbNoCiv.Text);
                    employee.Rue = tbRue.Text;
                    employee.Ville = tbVille.Text;
                    employee.IdProvince = tbProvince.Text;
                    employee.CodePostal = tbCode.Text.Replace(" ", "");
                    employee.Telephone = new string(tbTel.Text.Where(char.IsDigit).ToArray());
                    employee.Cellulaire = new string(tbCell.Text.Where(char.IsDigit).ToArray());
                    employee.Courriel = tbCourriel.Text;
                    employee.SalaireHoraire = decimal.Parse(tbSalaire.Text);
                    employee.Remarque = tbRemarque.Text;

                    db.SubmitChanges();
                    MessageBox.Show("Employé modifié avec succès", "Confirmation de la modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);

        }

        private void ModifEmp_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Employes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
