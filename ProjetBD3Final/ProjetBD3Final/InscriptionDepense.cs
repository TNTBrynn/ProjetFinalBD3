using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetBD3Final
{
    public partial class InscriptionDepense : Form
    {
        DataClassesDataContext dataContext = new DataClassesDataContext();
        private int loggedInUserNo;
        public InscriptionDepense(int loggedInUserNo)
        {
            InitializeComponent();
            this.loggedInUserNo = loggedInUserNo;
        }

        private void InscriptionDepense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Services);
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.AbonnementsDT' table. You can move, or remove it, as needed.
            this.abonnementsDTTableAdapter.Fill(this.bDB56Projet2GSDataSet.AbonnementsDT);
            //// TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Abonnements' table. You can move, or remove it, as needed.
            //this.abonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Abonnements);
            var requete = from abonnement in dataContext.Abonnements
                          let maxDateRenouvellement = abonnement.Reabonnements.Any() ? abonnement.Reabonnements.Max(r => r.DateRenouvellement) : (DateTime?)null
                          where abonnement.DateAbonnement.AddYears(1) >= DateTime.Now ||
                                (maxDateRenouvellement.HasValue && maxDateRenouvellement.Value.AddYears(1) >= DateTime.Now)
                          select abonnement;
            dgAbonnes.DataSource = requete;
            PopulateComboBox();

        }

        private void PopulateComboBox()
        {
            using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
            {
                var services = from service in db.Services
                               where service.NoEmploye == loggedInUserNo
                               select new { service.No, service.TypeService };

                cbService.DataSource = services.ToList();
                cbService.DisplayMember = "TypeService";
                cbService.ValueMember = "No";
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutDepense_Click(object sender, EventArgs e)
        {
            if (dgAbonnes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Il faut sélectionner un abonné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numMontant.Value < 1 || numMontant.Value >= 1000)
            {
                MessageBox.Show("Le montant doit être entre 1 et 1000.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedAbonnementId = (string)dgAbonnes.SelectedRows[0].Cells["Id"].Value;
            int noService = (int)cbService.SelectedValue;
            string remarque = string.IsNullOrWhiteSpace(tbRemarque.Text) ? null : tbRemarque.Text;

            using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
            {
                db.Connection.Open();
                using (var transaction = db.Connection.BeginTransaction())
                {
                    try
                    {
                        db.Transaction = transaction;

                        int nextId = db.Depenses.Max(dep => dep.No) + 1;

                        var newDepense = new Depenses
                        {
                            No = nextId,
                            IdAbonnement = selectedAbonnementId,
                            DateDepense = DateTime.Today,
                            Montant = numMontant.Value,
                            NoService = noService,
                            Remarque = remarque,
                            idEmploye = loggedInUserNo
                        };

                        db.Depenses.InsertOnSubmit(newDepense);
                        db.SubmitChanges();
                        transaction.Commit();

                        MessageBox.Show("La dépense est ajouté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Une erreur est survenu: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                db.Connection.Close();
            }
        }

    }
}
