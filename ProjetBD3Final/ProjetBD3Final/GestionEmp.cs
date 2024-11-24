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
    public partial class GestionEmp : Form
    {

        private int IdUtilisateur;

        public GestionEmp(int idUtilisateur)
        {
            InitializeComponent();
            IdUtilisateur = idUtilisateur;
        }

        private void GestionEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Employes);

        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            AjoutEmp ajoutEmp = new AjoutEmp();
            this.Hide();
            ajoutEmp.FormClosed += (s, args) => this.Show();
            ajoutEmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
