﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Provinces'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.provincesTableAdapter.Fill(this.bDB56Projet2GSDataSet.Provinces);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Dependants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dependantsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Dependants);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Reabonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reabonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Reabonnements);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet2GSDataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.bDB56Projet2GSDataSet.Abonnements);

        }

        private void dgAbonnements_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            string messageErreur = string.Empty;
            string prenom = dgAbonnements["dgTxtPrenom", e.RowIndex].Value?.ToString();
            string sexe = dgAbonnements["dgTxtSexe", e.RowIndex].Value?.ToString();
            string noCivique = dgAbonnements["dgTxtNoCivique", e.RowIndex].Value?.ToString();
            string rue = dgAbonnements["dgTxtRue", e.RowIndex].Value?.ToString();
            string ville = dgAbonnements["dgTxtVille", e.RowIndex].Value?.ToString();
            string idProvince = dgAbonnements["dgTxtIdProvince", e.RowIndex].Value?.ToString();
            string codePostal = dgAbonnements["dgTxtCodePostal", e.RowIndex].Value?.ToString();
            string telephone = dgAbonnements["dgTxtTelephone", e.RowIndex].Value?.ToString();
            string courriel = dgAbonnements["dgTxtCourriel", e.RowIndex].Value?.ToString();

            var regexTelephone = new System.Text.RegularExpressions.Regex(@"^\d{10}$");
            var regexCodePostal = new System.Text.RegularExpressions.Regex(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$");
            var regexNoCivique = new System.Text.RegularExpressions.Regex(@"^\d+$");


            if (String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(sexe) || String.IsNullOrEmpty(noCivique) || String.IsNullOrEmpty(rue) || String.IsNullOrEmpty(ville) || String.IsNullOrEmpty(idProvince) || String.IsNullOrEmpty(codePostal) || String.IsNullOrEmpty(telephone) || String.IsNullOrEmpty(courriel))
            {
                messageErreur = "Tous les champs sauf le champs Remarques sont requis";
            }
            else if (!regexTelephone.IsMatch(telephone))
            {
                messageErreur = "Le numéro de téléphone doit être composé de 10 chiffres";
            }
            else if (!regexCodePostal.IsMatch(codePostal))
            {
                messageErreur = "Le code postal doit être de la forme A1A1A1";
            }
            else if (!regexNoCivique.IsMatch(noCivique))
            {
                messageErreur = "Le numéro civique doit être un nombre";
            }

            dgAbonnements.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != string.Empty)
            {
                e.Cancel = true;
            }
        }
        private void dgAbonnements_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgAbonnements.Rows[e.RowIndex].ErrorText = "Le type de données de " + dgAbonnements.Columns[e.ColumnIndex].HeaderText + " n'est pas valide.";
            e.Cancel = true;
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
