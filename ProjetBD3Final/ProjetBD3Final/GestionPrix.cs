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
    public partial class GestionPrix : Form
    {
        public GestionPrix()
        {
            InitializeComponent();
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
    }
}
