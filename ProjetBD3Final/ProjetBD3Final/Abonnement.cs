using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

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
            DateTime dateNaissance = Convert.ToDateTime(dtDateNaissance.Value.ToShortDateString());
            string rue = tbRue.Text;
            string ville = tbVille.Text;
            string province = (string)cbProvince.SelectedValue;
            string codePostal = tbCodePostal.Text;
            string telephone = tbTelephone.Text;
            string cellulaire = tbCellulaire.Text;
            string courriel = tbCourriel.Text;
            int typeAbonnement = (int)lbTypeAbonnement.SelectedValue;
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
            if (sexe.Substring(0, 1) != "H" && sexe.Substring(0, 1) != "F" && sexe.Substring(0, 1) != "N")
            {
                messageErreur.SetError(cbSexe, "Le sexe est invalide, choississez depuis la liste déroulante");
                vide = true;
            }
            bool erreur = false;
            if (dateNaissance > DateTime.Today)
            {
                messageErreur.SetError(dtDateNaissance, "La date de naissance ne peut pas être dans le futur");
                erreur = true;
            }
            TimeSpan age = DateTime.Today - dateNaissance;
            if (age < new TimeSpan(365 * 18, 0, 0, 0))
            {
                messageErreur.SetError(dtDateNaissance, "L'abonné doit être majeur");
                erreur = true;
            }
            if (typeAbonnement == 2 && age < new TimeSpan(365 * 60, 0, 0, 0))
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
                dataContext.Connection.Open();
                using (var transaction = dataContext.Connection.BeginTransaction())
                {
                    try
                    {
                        dataContext.Transaction = transaction;

                        int nbAbonnement = (from abonnement in dataContext.Abonnements
                                            select abonnement).Count();
                        Abonnements newAbonnement = new Abonnements
                        {
                            Id = nom + (nbAbonnement + 1) + "P",
                            DateAbonnement = DateTime.Today,
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
                            NoTypeAbonnement = typeAbonnement,
                            Remarque = remarque,

                        };
                        dataContext.Abonnements.InsertOnSubmit(newAbonnement);

                        if (typeAbonnement == 1 || typeAbonnement == 2) //solo
                        {
                            dataContext.SubmitChanges();
                            transaction.Commit();
                            MessageBox.Show("Abonnement ajouté avec succès");
                        }
                        else
                        {
                            Dependants dependantConjoint = new Dependants();
                            dependantConjoint.Id = "C";

                            AbonnementDependants formAbonnementConjoint = new AbonnementDependants(dependantConjoint);
                            formAbonnementConjoint.ShowDialog();
                            dependantConjoint = formAbonnementConjoint.dependant;

                            if (dependantConjoint.Nom != null)
                            {
                                dependantConjoint.Id = newAbonnement.Nom + (nbAbonnement + 1) + dependantConjoint.Sexe + 0;
                                dependantConjoint.IdAbonnement = newAbonnement.Id;
                                dataContext.Dependants.InsertOnSubmit(dependantConjoint);

                                if (typeAbonnement == 3) //couple
                                {
                                    dataContext.SubmitChanges();
                                    transaction.Commit();
                                    MessageBox.Show("Abonné et conjoint ajouté avec succès");
                                }
                                Dependants[] listDependantsEnfants;
                                if (typeAbonnement == 4) //famille 1 enfants
                                {
                                    Dependants dependantEnfant = new Dependants();
                                    dependantEnfant.Id = "E";

                                    AbonnementDependants formAbonnementEnfant = new AbonnementDependants(dependantEnfant);
                                    formAbonnementEnfant.ShowDialog();
                                    dependantEnfant = formAbonnementEnfant.dependant;

                                    if (dependantEnfant.Nom != null)
                                    {
                                        dependantEnfant.Id = newAbonnement.Nom + (nbAbonnement + 1) + "E1";
                                        dependantEnfant.IdAbonnement = newAbonnement.Id;
                                        dataContext.Dependants.InsertOnSubmit(dependantEnfant);

                                        dataContext.SubmitChanges();
                                        transaction.Commit();
                                        MessageBox.Show("Abonné, conjoint et enfant ajouté avec succès");
                                    }
                                    else
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Enregistrement de l'enfant annulé. Aucune opération effectué ou enregistrer.\n" +
                                            "Vous devrez réenregistrer l'abonnée principal et son/sa conjoint(e)");
                                    }
                                }
                                else if (typeAbonnement == 5) //famille 2 enfants
                                {
                                    //modifier pour liste
                                    listDependantsEnfants = new Dependants[2];
                                    for (int i = 1; i <= 2; i++)
                                    {
                                        Dependants dependantEnfant = new Dependants();
                                        dependantEnfant.Id = "E";

                                        AbonnementDependants formAbonnementEnfant = new AbonnementDependants(dependantEnfant);
                                        formAbonnementEnfant.ShowDialog();
                                        dependantEnfant = formAbonnementEnfant.dependant;

                                        if (dependantEnfant.Nom != null)
                                        {
                                            dependantEnfant.Id = newAbonnement.Nom + (nbAbonnement + 1) + "E" + i;
                                            dependantEnfant.IdAbonnement = newAbonnement.Id;
                                            dataContext.Dependants.InsertOnSubmit(dependantEnfant);
                                        }
                                        else
                                        {
                                            transaction.Rollback();
                                            MessageBox.Show("Enregistrement de l'enfant annulé. Aucune opération effectué ou enregistrer.\n" +
                                                "Vous devrez réenregistrer l'abonnée principal et son/sa conjoint(e)");
                                            break;
                                        }
                                    }
                                    if (listDependantsEnfants[0].Nom != null || listDependantsEnfants[1].Nom != null)
                                    {
                                        dataContext.SubmitChanges();
                                        transaction.Commit();
                                        MessageBox.Show("Abonné, conjoint et 2 enfants ajouté avec succès");
                                    }

                                }
                            }
                            else //conjoint echec
                            {
                                transaction.Rollback();
                                MessageBox.Show("Enregistrement du conjoint annulé. Aucune opération effectué ou enregistrer.\n" +
                                    "Vous devrez réenregistrer l'abonnée principal et son/sa conjoint(e)");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur lors de l'ajout de l'abonnement: " + ex.Message);
                    }
                }
            }
            dataContext.Connection.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
