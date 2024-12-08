using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBD3Final
{
    public partial class Reabonnement : Form
    {
        private DataClassesDataContext dataContext = new DataClassesDataContext();

        public Reabonnement()
        {
            InitializeComponent();
        }

        private void Reabonnement_Load(object sender, EventArgs e)
        {
            /*
             * pour chaque id
             * 
             * si date abonnement + 1 an < date courante
             * si oui, voir si il existe un reabonnement
             * si non, afficher l'abonnement
             * si oui et si date reabonnement la plus récente + 1 an < date courante
             * afficher l'abonnement
             */

            var requete1 = from abonnement in dataContext.Abonnements
                           where abonnement.DateAbonnement.AddYears(1) < DateTime.Now &&
                           (!abonnement.Reabonnements.Any() ||
                           abonnement.Reabonnements.Max(r => r.DateRenouvellement).AddYears(1) < DateTime.Now)
                           select new
                           {
                               Id = abonnement.Id,
                               NomComplet = abonnement.Prenom + " " + abonnement.Nom,
                           };
            dgAbonnement.DataSource = requete1;
        }

        private void btnRenouveller_Click(object sender, EventArgs e)
        {
            if (dgAbonnement.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un abonnement");
                return;
            }
            else
            {
                string idAbonnement = dgAbonnement.CurrentRow.Cells[0].Value.ToString();
                string remarque = tbRemarque.Text;



                dataContext.Connection.Open();
                using (var transaction = dataContext.Connection.BeginTransaction())
                {
                    try
                    {
                        dataContext.Transaction = transaction;
                        Reabonnements reabonnement = new Reabonnements
                        {
                            IdAbonnement = idAbonnement,
                            DateRenouvellement = DateTime.Today,
                            Remarque = remarque,
                        };
                        dataContext.Reabonnements.InsertOnSubmit(reabonnement);
                        dataContext.SubmitChanges();
                        transaction.Commit();
                        MessageBox.Show("Reabonnement effectué avec succès");
                        Reabonnement_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur: " + ex.Message);
                        transaction.Rollback();
                    }
                    dataContext.Connection.Close();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
