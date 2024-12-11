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
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.bDB56Projet2GSDataSet.DataTable2);
            // TODO: This line of code loads data into the 'bDB56Projet2GSDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.bDB56Projet2GSDataSet.DataTable1);

            // Handle the SelectionChanged event
            dgEmployes.SelectionChanged += dgEmployes_SelectionChanged_1;

            dgEmployes_SelectionChanged_1(dgEmployes, EventArgs.Empty);

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
    }
}

