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
    public partial class MenuAdministrateur : Form
    {

        private int IdUtilisateur;

        public MenuAdministrateur(int idUtilisateur)
        {
            InitializeComponent();
            IdUtilisateur = idUtilisateur;
        }

        private void MenuAdministrateur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionEmp gestionEmp = new GestionEmp(IdUtilisateur);
            this.Hide();
            gestionEmp.FormClosed += (s, args) => this.Show();
            gestionEmp.Show();
        }
    }
}
