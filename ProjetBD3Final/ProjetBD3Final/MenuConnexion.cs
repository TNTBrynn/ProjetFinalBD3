using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetBD3Final
{
    public partial class MenuConnexion : Form
    {
        string connexionString = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet2GS;Persist Security Info=True;User ID=B56Projet2GS;Password=Password1;TrustServerCertificate=True";
        public MenuConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = tbNomUtilisateur.Text;
            string motDePasse = tbMDP.Text;
            int idUtilisateur = 0;
            int idTypeUtilisateur = 0;

            SqlConnection connexion = new SqlConnection(connexionString);
            connexion.Open();
            String requete = "select * from Employes where No = @nomUtilisateur and motDePasse = @mdp";
            SqlCommand command = new SqlCommand(requete, connexion);
            command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
            command.Parameters.AddWithValue("@mdp", motDePasse);
            // Le mot de passe doit être sécuritaire (chiffre, caractère, ...) et donc doit être vérifé
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                idUtilisateur = reader.GetInt32(0);
                idTypeUtilisateur = reader.GetInt32(15);
            }
            else
            {
                MessageBox.Show("Cette utilisateur n'existe pas", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            connexion.Close();

            if (idTypeUtilisateur == 1)
            {
                MenuAdministrateur menuAdmin = new MenuAdministrateur(idUtilisateur);
                this.Hide();
                menuAdmin.FormClosed += (s, args) => this.Show();
                menuAdmin.Show();
            }
        }

        private void tbNomUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class FormManager
    {
        private static FormManager instance = null;
        private MenuAdministrateur menuAdministrateur { get; set; }
        private GestionEmp gestionEmp { get; set; }

        private FormManager() { }

        public MenuAdministrateur MenuAdministrateur(int currentUserId)
        {
            if (menuAdministrateur == null || menuAdministrateur.IsDisposed)
            {
                menuAdministrateur = new MenuAdministrateur(currentUserId);
            }
            return menuAdministrateur;

        }

        public GestionEmp GestionEmp(int currentUserId)
        {
            if (gestionEmp == null || gestionEmp.IsDisposed)
            {
                gestionEmp = new GestionEmp(currentUserId);
            }
            return gestionEmp;
        }

        public static FormManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormManager();
                }
                return instance;
            }
        }
    }
}
