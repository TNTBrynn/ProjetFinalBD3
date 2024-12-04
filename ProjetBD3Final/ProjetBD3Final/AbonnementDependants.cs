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
    public partial class AbonnementDependants : Form
    {
        public Dependants dependant;
        public AbonnementDependants(Dependants dependant)
        {
            InitializeComponent();
            this.dependant = dependant;
        }

        private void dependantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dependantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);
        }

        private void AbonnementConjoint_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Dependants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dependantsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Dependants);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            messageErreur.Clear();
            string nom = tbNom.Text;
            string prenom = tbPrenom.Text;
            string sexe = cbSexe.Text;
            DateTime dateNaissance = dtDateNaissance.Value;
            string remarque = tbRemarque.Text;
            bool vide = false;

            if (nom.Trim() == "")
            {
                messageErreur.SetError(tbNom, "Le nom est obligatoire");
                vide = true;
            }
            if (prenom.Trim() == "")
            {
                messageErreur.SetError(tbPrenom, "Le prénom est obligatoire");
                vide = true;
            }
            if (sexe.Trim() == "")
            {
                messageErreur.SetError(cbSexe, "Le sexe est obligatoire");
                vide = true;
            }
            bool erreur = false;
            if (dateNaissance > DateTime.Now)
            {
                messageErreur.SetError(dtDateNaissance, "La date de naissance ne peut pas être dans le futur");
                erreur = true;
            }
            TimeSpan age = DateTime.Now - dateNaissance;
            if(dependant.Id == "C")
            {
                if (age < new TimeSpan(365 * 18, 0, 0, 0))
                {
                    messageErreur.SetError(dtDateNaissance, "Le conjoint doit être majeur");
                    erreur = true;
                }
            }
            else
            {
                if(age < new TimeSpan(365 * 1, 0, 0, 0))
                {
                    messageErreur.SetError(dtDateNaissance, "L'enfant doit être agé d'au moins 1 ans");
                    erreur = true;
                }
                else if (age > new TimeSpan(365 * 18, 0, 0, 0))
                {
                    messageErreur.SetError(dtDateNaissance, "L'enfant ne peut pas être majeur");
                    erreur = true;
                }
            }
            if (sexe.Substring(0, 1) != "H" && sexe.Substring(0, 1) != "F" && sexe.Substring(0, 1) != "N")
            {
                messageErreur.SetError(cbSexe, "Le sexe est invalide, choississez depuis la liste déroulante");
                vide = true;
            }
            if (!erreur && !vide)
            {
                dependant = new Dependants
                {
                    Id = "",
                    Nom = nom,
                    Prenom = prenom,
                    Sexe = Convert.ToChar(sexe.Substring(0, 1)),
                    DateNaissance = dateNaissance,
                    IdAbonnement = "",
                    Remarque = remarque
                };
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
