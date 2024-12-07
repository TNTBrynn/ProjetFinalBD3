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
    public partial class InscriptionDepense : Form
    {
        public InscriptionDepense()
        {
            InitializeComponent();
        }

        private void abonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);

        }

        private void InscriptionDepense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Services);
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.AbonnementsDT' table. You can move, or remove it, as needed.
            this.abonnementsDTTableAdapter.Fill(this.bDB56Projet2GSDataSet.AbonnementsDT);
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Abonnements' table. You can move, or remove it, as needed.
            this.abonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Abonnements);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
