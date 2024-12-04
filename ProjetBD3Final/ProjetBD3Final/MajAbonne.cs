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
    public partial class MajAbonne : Form
    {
        public MajAbonne()
        {
            InitializeComponent();
        }

        private void abonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);

        }

        private void MajAbonne_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Dependants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dependantsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Dependants);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Reabonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reabonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Reabonnements);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Abonnements);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
