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
    public partial class GestionPrix : Form
    {
        public GestionPrix()
        {
            InitializeComponent();
            dgPrix.CellBeginEdit += dgPrix_CellBeginEdit;
            dgPrix.CellEndEdit += dgPrix_CellEndEdit;
        }

        private void prixDepensesAbonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prixDepensesAbonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);

        }

        private void GestionPrix_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.dtTypeEtPrixDepensesAbonnements' table. You can move, or remove it, as needed.
            this.dtTypeEtPrixDepensesAbonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.dtTypeEtPrixDepensesAbonnements);
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.PrixDepensesAbonnements' table. You can move, or remove it, as needed.
            this.prixDepensesAbonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.PrixDepensesAbonnements);

        }

        private void dtTypeEtPrixDepensesAbonnementsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPrixDepensesAbonnements()
        {
            using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
            {

                var requete2 = from prix in db.PrixDepensesAbonnements
                               let dateAjout = new DateTime(prix.Annee, 1, 1)
                               where dateAjout.AddYears(1) < DateTime.Now
                               select prix;
                prixDepensesAbonnementsBindingSource.DataSource = requete2.ToList();
            }
        }


        private void btnModif_Click(object sender, EventArgs e)
        {
            
        }

        private void dgPrix_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var selectedRow = dgPrix.Rows[e.RowIndex];
            var annee = (int)selectedRow.Cells["Annee"].Value;
            var dateAjout = new DateTime(annee, 1, 1);

            if (dateAjout.AddYears(1) >= DateTime.Now)
            {
                MessageBox.Show("La modification de ce prix / dépense n'est pas encore disponible.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        private void dgPrix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgPrix.Rows[e.RowIndex];
            var newValue = selectedRow.Cells[e.ColumnIndex].Value.ToString();

            if (decimal.TryParse(newValue, out decimal newPrice) && newPrice >= 0)
            {
                using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
                {
                    var description = selectedRow.Cells["Id"].Value;
                    var annee = (int)selectedRow.Cells["Annee"].Value;

                    var prixRecord = db.PrixDepensesAbonnements.SingleOrDefault(p => p.NoTypeAbonnement == (int)description && p.Annee == annee);

                    if (prixRecord != null)
                    {
                        prixRecord.Prix = newPrice;

                        db.SubmitChanges();

                        MessageBox.Show("Prix modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Enregistrement non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Prix invalide. Entrée une valeur monétaire valide.", "Valeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgPrix.CancelEdit();
            }
        }
    }
}
