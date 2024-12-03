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
    public partial class Abonnement : Form
    {
        private DataClassesDataContext dataContext = new DataClassesDataContext();
        public Abonnement()
        {
            InitializeComponent();
        }

        private void abonnementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonnementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet2GSDataSet);

        }

        private void Abonnement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.TypesAbonnement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typesAbonnementTableAdapter.Fill(this.bDB56Projet2GSDataSet.TypesAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.TypesAbonnement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typesAbonnementTableAdapter.Fill(this.bDB56Projet2GSDataSet.TypesAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Provinces'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.provincesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Provinces);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Abonnements);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            messageErreur.Clear();
            string nom = tbNom.Text;
            string prenom = tbPrenom.Text;
            string sexe = cbSexe.Text;
            string noCivique = numNoCivique.Text;
            DateTime dateNaissance = dtDateNaissance.Value;
            string rue = tbRue.Text;
            string ville = tbVille.Text;
            string province = cbProvince.Text;
            string codePostal = tbCodePostal.Text;
            string telephone = tbTelephone.Text;
            string cellulaire = tbCellulaire.Text;
            string courriel = tbCourriel.Text;
            string typeAbonnement = lbTypeAbonnement.Text;
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
            if (noCivique.Trim() == "")
            {
                messageErreur.SetError(numNoCivique, "Le numéro civique est obligatoire");
                vide = true;
            }
            if (rue.Trim() == "")
            {
                messageErreur.SetError(tbRue, "La rue est obligatoire");
                vide = true;
            }
            if (ville.Trim() == "")
            {
                messageErreur.SetError(tbVille, "La ville est obligatoire");
                vide = true;
            }
            if (province.Trim() == "")
            {
                messageErreur.SetError(cbProvince, "La province est obligatoire");
                vide = true;
            }
            if (codePostal.Trim() == "")
            {
                messageErreur.SetError(tbCodePostal, "Le code postal est obligatoire");
                vide = true;
            }
            if (telephone.Trim() == "")
            {
                messageErreur.SetError(tbTelephone, "Le téléphone est obligatoire");
                vide = true;
            }
            if (courriel.Trim() == "")
            {
                messageErreur.SetError(tbCourriel, "Le courriel est obligatoire");
                vide = true;
            }
            if (typeAbonnement.Trim() == "")
            {
                messageErreur.SetError(lbTypeAbonnement, "Le type d'abonnement est obligatoire");
                vide = true;
            }
            if (sexe.Substring(0, 1) != "H" && sexe.Substring(0, 1) != "F" && sexe.Substring(0, 1) != "N")
            {
                messageErreur.SetError(cbSexe, "Le sexe est invalide, choississez depuis la liste déroulante");
                vide = true;
            }
            bool erreur = false;
            if (dateNaissance > DateTime.Now)
            {
                messageErreur.SetError(dtDateNaissance, "La date de naissance ne peut pas être dans le futur");
                erreur = true;
            }
            TimeSpan age = DateTime.Now - dateNaissance;
            if (age < new TimeSpan(365 * 18, 0, 0, 0))
            {
                messageErreur.SetError(dtDateNaissance, "L'abonné doit être majeur");
                erreur = true;
            }
            if ((int)lbTypeAbonnement.SelectedValue == 2 && age < new TimeSpan(365 * 60, 0, 0, 0))
            {
                messageErreur.SetError(lbTypeAbonnement, "L'abonné doit avoir plus de 60 ans pour être éligible à l'abonnement Âge d'or");
                erreur = true;
            }
            if (telephone.Length != 10)
            {
                messageErreur.SetError(tbTelephone, "Le numéro de téléphone doit être composé de 10 chiffres");
                erreur = true;
            }

            //tout ok
            if (!erreur && !vide)
            {
                int nbAbonnement = (from abonnement in dataContext.Abonnements
                                    select abonnement).Count();

                Abonnements newAbonnement = new Abonnements
                {
                    Id = nom + (nbAbonnement + 1) + "P",
                    DateAbonnement = DateTime.Now,
                    Nom = nom,
                    Prenom = prenom,
                    Sexe = Convert.ToChar(sexe.Substring(0, 1)),
                    DateNaissance = dateNaissance,
                    NoCivique = Convert.ToInt32(noCivique),
                    Rue = rue,
                    Ville = ville,
                    IdProvince = province,
                    CodePostal = codePostal,
                    Telephone = telephone,
                    Cellulaire = cellulaire,
                    Courriel = courriel,
                    NoTypeAbonnement = (int)lbTypeAbonnement.SelectedValue,
                    Remarque = remarque,

                };
                dataContext.Abonnements.InsertOnSubmit(newAbonnement);

                if ((int)lbTypeAbonnement.SelectedValue == 1 || (int)lbTypeAbonnement.SelectedValue == 2)
                {
                    //dataContext.SubmitChanges();
                    MessageBox.Show("Abonnement ajouté avec succès");

                }
                else
                {
                    Dependants dependantConjoint = new Dependants();

                    AbonnementConjoint abonnementConjoint = new AbonnementConjoint(dependantConjoint);
                    abonnementConjoint.ShowDialog();

                    dependantConjoint.Id = newAbonnement.Nom + (nbAbonnement + 1) + dependantConjoint.Sexe + 0;
                    dependantConjoint.IdAbonnement = newAbonnement.Id;
                    dataContext.Dependants.InsertOnSubmit(dependantConjoint);
                    if ((int)lbTypeAbonnement.SelectedValue == 3 && dependantConjoint.Nom != null) //couple
                    {
                        //dataContext.SubmitChanges();
                        MessageBox.Show("Abonné et conjoint ajouté avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Échec de l'enregistrement de l'abonné");
                    }
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
