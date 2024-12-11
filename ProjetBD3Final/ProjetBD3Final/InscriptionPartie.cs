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

namespace ProjetBD3Final
{
    public partial class InscriptionPartie : Form
    {
        private DataClassesDataContext dataContext = new DataClassesDataContext();

        public InscriptionPartie()
        {
            InitializeComponent();
        }

        private void InscriptionPartie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Terrains'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.terrainsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Terrains);

            var abonnementValide = from abonnement in dataContext.Abonnements
                                   let maxDateRenouvellement = abonnement.Reabonnements.Any() ? abonnement.Reabonnements.Max(r => r.DateRenouvellement) : (DateTime?)null
                                   where abonnement.DateAbonnement.AddYears(1) >= DateTime.Now ||
                                         (maxDateRenouvellement.HasValue && maxDateRenouvellement.Value.AddYears(1) >= DateTime.Now)
                                   select new
                                   {
                                       Id = abonnement.Id,
                                       NomComplet = abonnement.Prenom + " " + abonnement.Nom,
                                   };
            dgAbonnement.DataSource = abonnementValide;
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            messageErreur.Clear();
            string idAbonnement = tbId.Text;
            string terrain = cbTerrain.SelectedValue?.ToString();
            int pointage = (int)numPointage.Value;
            string remarque = tbRemarque.Text;
            bool erreur = false;

            if (String.IsNullOrEmpty(idAbonnement))
            {
                messageErreur.SetError(tbId, "Veuillez sélectionner un abonnement");
                erreur = true;
            }
            if (String.IsNullOrEmpty(terrain))
            {
                messageErreur.SetError(cbTerrain, "Veuillez sélectionner un terrain");
                erreur = true;
            }

            if (!erreur)
            {
                PartiesJouees partiesJouees = new PartiesJouees
                {
                    IdAbonnement = idAbonnement,
                    NoTerrain = Convert.ToInt32(terrain),
                    DatePartie = DateTime.Today,
                    Pointage = Convert.ToInt32(pointage),
                    Remarque = tbRemarque.Text
                };
                dataContext.PartiesJouees.InsertOnSubmit(partiesJouees);

                dataContext.Connection.Open();
                using (var transaction = dataContext.Connection.BeginTransaction())
                {
                    try
                    {
                        dataContext.Transaction = transaction;
                        dataContext.SubmitChanges();
                        transaction.Commit();
                        MessageBox.Show("Inscription de la partie réussite");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur: " + ex.Message);
                    }
                }
                dataContext.Connection.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgAbonnement_SelectionChanged(object sender, EventArgs e)
        {
            string id = dgAbonnement.CurrentRow.Cells[0].Value?.ToString();
            if (id != null)
            {
                tbId.Text = id;
            }
            else
            {
                tbId.Text = "";
            }
        }
    }
}
