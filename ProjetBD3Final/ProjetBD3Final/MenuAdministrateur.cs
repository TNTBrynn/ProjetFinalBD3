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
        private int idTypeUtilisateur;

        public MenuAdministrateur(int idUtilisateur, int IdTypeUtilisateur)
        {
            InitializeComponent();
            IdUtilisateur = idUtilisateur;
            idTypeUtilisateur = IdTypeUtilisateur;
        }

        private void MenuAdministrateur_Load(object sender, EventArgs e)
        {
            if (idTypeUtilisateur == 1)
            {
                
            }
            else if (idTypeUtilisateur == 2)
            {
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMajAbonne.Enabled = false;
                btnInscriptionPartie.Enabled = false;
            }
            else if (idTypeUtilisateur == 3)
            {
                button1.Enabled = false;
            }
            else if (idTypeUtilisateur == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMajAbonne.Enabled = false;
                btnStatistiques.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (idTypeUtilisateur == 5)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMajAbonne.Enabled = false;
                btnStatistiques.Enabled = false;
                button4.Enabled = false;

            }
            else if (idTypeUtilisateur == 6)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMajAbonne.Enabled = false;
                btnStatistiques.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMajAbonne.Enabled = false;
                btnStatistiques.Enabled = false;
                button4.Enabled = false;
            }



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
        private void button3_Click(object sender, EventArgs e)
        {
            InscriptionDepense gestionPrix = new InscriptionDepense(IdUtilisateur);
            this.Hide();
            gestionPrix.FormClosed += (s, args) => this.Show();
            gestionPrix.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rapport rapport = new Rapport();
            this.Hide();
            rapport.FormClosed += (s, args) => this.Show();
            rapport.Show();
        }
    }
}
