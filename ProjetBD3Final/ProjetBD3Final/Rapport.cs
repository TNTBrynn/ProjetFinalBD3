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
    public partial class Rapport : Form
    {
        private DataClassesDataContext dataContext = new DataClassesDataContext();
        public Rapport()
        {
            InitializeComponent();
            this.Load += Rapport_Load;
            dgAbonnements.SelectionChanged += dgAbonnements_SelectionChanged;
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Depenses' table. You can move, or remove it, as needed.
            this.depensesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Depenses);
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.bDB56Projet2GSDataSet.DataTable2);
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.bDB56Projet2GSDataSet.DataTable1);

            // Handle the SelectionChanged event
            dgEmployes.SelectionChanged += dgEmployes_SelectionChanged_1;

            dgEmployes_SelectionChanged_1(dgEmployes, EventArgs.Empty);

            // Charger les données initiales dans dgAbonnements
            var abonnements = from a in dataContext.Abonnements
                              select new
                              {
                                  NomComplet = a.Prenom + " " + a.Nom,
                                  AbonnementId = a.Id
                              };
            dgAbonnements.DataSource = abonnements.ToList();

            // Manuellement déclencher l'événement SelectionChanged
            dgAbonnements_SelectionChanged(dgAbonnements, EventArgs.Empty);

            var annees = (from d in dataContext.Depenses
                          select d.DateDepense.Year).Distinct().ToList();
            cbAnnee.DataSource = annees;
            cbAnnee2.DataSource = annees;

            var terrains = from t in dataContext.Terrains
                           select new
                           {
                               t.Nom,
                               Id = t.No
                           };
            dgTerrains.DataSource = terrains.ToList();

            var abonnements2 = from a in dataContext.Abonnements
                               select new
                               {
                                   NomComplet = a.Prenom + " " + a.Nom,
                                   a.Id
                               };
            dgAbonnement2.DataSource = abonnements2.ToList();

        }

        private void dgEmployes_SelectionChanged_1(object sender, EventArgs e)
        {
            dgDepenses.ClearSelection();
            if (dgEmployes.SelectedRows.Count > 0)
            {
                string selectedEmployee = dgEmployes.SelectedRows[0].Cells["NomComplet"].Value.ToString();
                dgDepenses.CurrentCell = null; // Ensure no cell is selected

                foreach (DataGridViewRow row in dgDepenses.Rows)
                {
                    if (row.Cells["NomCompletE"].Value != null && row.Cells["NomCompletE"].Value.ToString() == selectedEmployee)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgAbonnements_SelectionChanged(object sender, EventArgs e)
        {
            dgDepenses2.ClearSelection();
            if (dgAbonnements.SelectedRows.Count > 0)
            {
                string selectedAbonnementId = dgAbonnements.SelectedRows[0].Cells["AbonnementId"].Value.ToString();

                var expenses = from d in dataContext.Depenses
                               join f in dataContext.Employes on d.idEmploye equals f.No
                               join s in dataContext.Services on d.NoService equals s.No
                               where d.IdAbonnement == selectedAbonnementId
                               select new
                               {
                                   d.Montant,
                                   d.DateDepense,
                                   ServiceDescription = s.TypeService,
                                   EmployeNomComplet = f.Prenom + " " + f.Nom
                               };

                dgDepenses2.DataSource = expenses.ToList();
            }
        }

        private void cbAnnee_SelectedIndexChanged(object sender, EventArgs z)
        {
            int selectedYear = (int)cbAnnee.SelectedItem;

            var expenses = from d in dataContext.Depenses
                           join a in dataContext.Abonnements on d.IdAbonnement equals a.Id
                           join e in dataContext.Employes on d.idEmploye equals e.No
                           join s in dataContext.Services on d.NoService equals s.No
                           where d.DateDepense.Year == selectedYear
                           select new
                           {
                               AbonneNomComplet = a.Prenom + " " + a.Nom,
                               d.Montant,
                               d.DateDepense,
                               ServiceDescription = s.TypeService,
                               EmployeNomComplet = e.Prenom + " " + e.Nom
                           };

            dgDepenses3.DataSource = expenses.ToList();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dgTerrains_SelectionChanged(object sender, EventArgs e)
        {
            dgParties.ClearSelection();
            if (dgTerrains.SelectedRows.Count > 0)
            {
                int selectedTerrainId = (int)dgTerrains.SelectedRows[0].Cells["Id"].Value;

                var parties = from p in dataContext.PartiesJouees
                              join a in dataContext.Abonnements on p.IdAbonnement equals a.Id
                              where p.NoTerrain == selectedTerrainId
                              select new
                              {
                                  p.DatePartie,
                                  AbonneNomComplet = a.Prenom + " " + a.Nom,
                                  p.Pointage
                              };

                dgParties.DataSource = parties.ToList();
            }
        }

        private void dgAbonnement2_SelectionChanged(object sender, EventArgs e)
        {
            dgParties2.ClearSelection();
            if (dgAbonnement2.SelectedRows.Count > 0)
            {
                string selectedAbonnementId = dgAbonnement2.SelectedRows[0].Cells["Id"].Value.ToString();

                var parties = from p in dataContext.PartiesJouees
                              join t in dataContext.Terrains on p.NoTerrain equals t.No
                              where p.IdAbonnement == selectedAbonnementId
                              select new
                              {
                                  p.DatePartie,
                                  TerrainNom = t.Nom,
                                  p.Pointage
                              };

                dgParties2.DataSource = parties.ToList();
            }
        }

        private void cbAnnee2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = (int)cbAnnee2.SelectedItem;

            var parties = from p in dataContext.PartiesJouees
                          join a in dataContext.Abonnements on p.IdAbonnement equals a.Id
                          join t in dataContext.Terrains on p.NoTerrain equals t.No
                          where p.DatePartie.Year == selectedYear
                          select new
                          {
                              p.DatePartie,
                              AbonneNomComplet = a.Prenom + " " + a.Nom,
                              TerrainNom = t.Nom,
                              p.Pointage
                          };

            dgParties3.DataSource = parties.ToList();
        }
    }
}

