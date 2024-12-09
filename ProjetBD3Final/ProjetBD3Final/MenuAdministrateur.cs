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

        private void button2_Click(object sender, EventArgs e)
        {
            GestionPrix gestionPrix = new GestionPrix();
            this.Hide();
            gestionPrix.FormClosed += (s, args) => this.Show();
            gestionPrix.Show();
        }

        private void btnAbonnement_Click(object sender, EventArgs e)
        {
            Abonnement abonnement = new Abonnement();
            this.Hide();
            abonnement.FormClosed += (s, args) => this.Show();
            abonnement.Show();
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            Reabonnement reabonnement = new Reabonnement();
            this.Hide();
            reabonnement.FormClosed += (s, args) => this.Show();
            reabonnement.Show();
        }

        private void btnMajAbonne_Click(object sender, EventArgs e)
        {
            MajAbonne majAbonne = new MajAbonne();
            this.Hide();
            majAbonne.FormClosed += (s, args) => this.Show();
            majAbonne.Show();
        }

        private void btnInscriptionPartie_Click(object sender, EventArgs e)
        {
            InscriptionPartie inscriptionPartie = new InscriptionPartie();
            this.Hide();
            inscriptionPartie.FormClosed += (s, args) => this.Show();
            inscriptionPartie.Show();
        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            Statistiques statistiques = new Statistiques();
            this.Hide();
            statistiques.FormClosed += (s, args) => this.Show();
            statistiques.Show();
        }
    }
}
