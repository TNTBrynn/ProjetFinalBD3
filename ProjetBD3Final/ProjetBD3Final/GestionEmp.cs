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
            ajoutEmp.FormClosed += (s, args) => this.Show(); this.employesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Employes); ;
            ajoutEmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgEmployes.SelectedRows.Count > 0)
            {
                int selectedEmployeeNo = (int)dgEmployes.SelectedRows[0].Cells["No"].Value;
                ModifEmp modifEmpForm = new ModifEmp(selectedEmployeeNo);
                modifEmpForm.ShowDialog();
                this.employesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Employes);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un employé à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (dgEmployes.SelectedRows.Count > 0)
            {
                int selectedEmployeeNo = (int)dgEmployes.SelectedRows[0].Cells["No"].Value;

                if (selectedEmployeeNo == 1)
                {
                    MessageBox.Show("L'administrateur ne peut pas être supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Voulez-vous vraiment supprimer cet employé?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var db = new BDB56Projet2GSDataContext("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True"))
                    {
                        var employee = db.Employes.SingleOrDefault(emp => emp.No == selectedEmployeeNo);
                        if (employee != null)
                        {
                            db.Employes.DeleteOnSubmit(employee);
                            db.SubmitChanges();
                            MessageBox.Show("Employé supprimer avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.employesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Employes);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionner un employé à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}