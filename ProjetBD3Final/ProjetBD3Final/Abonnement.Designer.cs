namespace ProjetBD3Final
{
    partial class Abonnement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label noTypeAbonnementLabel;
            System.Windows.Forms.Label remarqueLabel;
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.AbonnementsTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.dtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.ProvincesTableAdapter();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesAbonnementTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TypesAbonnementTableAdapter();
            this.typesAbonnementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbTypeAbonnement = new System.Windows.Forms.ListBox();
            this.tbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.tbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.tbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.messageErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.numNoCivique = new System.Windows.Forms.NumericUpDown();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            noTypeAbonnementLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet2GSDataSet
            // 
            this.bDB56Projet2GSDataSet.DataSetName = "BDB56Projet2GSDataSet";
            this.bDB56Projet2GSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataMember = "Abonnements";
            this.abonnementsBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // abonnementsTableAdapter
            // 
            this.abonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = this.abonnementsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = this.provincesTableAdapter;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = this.typesAbonnementTableAdapter;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(29, 65);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Nom", true));
            this.tbNom.Location = new System.Drawing.Point(149, 62);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(200, 20);
            this.tbNom.TabIndex = 6;
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(29, 91);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 7;
            prenomLabel.Text = "Prenom:";
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Prenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(149, 88);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(200, 20);
            this.tbPrenom.TabIndex = 8;
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(29, 117);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 9;
            sexeLabel.Text = "Sexe:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(29, 144);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(86, 13);
            dateNaissanceLabel.TabIndex = 11;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // dtDateNaissance
            // 
            this.dtDateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateNaissance", true));
            this.dtDateNaissance.Location = new System.Drawing.Point(149, 140);
            this.dtDateNaissance.MaxDate = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            this.dtDateNaissance.Name = "dtDateNaissance";
            this.dtDateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dtDateNaissance.TabIndex = 12;
            this.dtDateNaissance.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(29, 169);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 13;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(29, 195);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 15;
            rueLabel.Text = "Rue:";
            // 
            // tbRue
            // 
            this.tbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Rue", true));
            this.tbRue.Location = new System.Drawing.Point(149, 192);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(200, 20);
            this.tbRue.TabIndex = 16;
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(29, 221);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 17;
            villeLabel.Text = "Ville:";
            // 
            // tbVille
            // 
            this.tbVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Ville", true));
            this.tbVille.Location = new System.Drawing.Point(149, 218);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(200, 20);
            this.tbVille.TabIndex = 18;
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(29, 247);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 19;
            idProvinceLabel.Text = "Province:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(29, 273);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 21;
            codePostalLabel.Text = "Code Postal:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(29, 299);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 23;
            telephoneLabel.Text = "Telephone:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(29, 325);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(52, 13);
            cellulaireLabel.TabIndex = 25;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(29, 351);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 27;
            courrielLabel.Text = "Courriel:";
            // 
            // tbCourriel
            // 
            this.tbCourriel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Courriel", true));
            this.tbCourriel.Location = new System.Drawing.Point(149, 348);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(200, 20);
            this.tbCourriel.TabIndex = 28;
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Location = new System.Drawing.Point(404, 40);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(104, 13);
            noTypeAbonnementLabel.TabIndex = 29;
            noTypeAbonnementLabel.Text = "Type d\'abonnement:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(29, 377);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 31;
            remarqueLabel.Text = "Remarque:";
            // 
            // tbRemarque
            // 
            this.tbRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Remarque", true));
            this.tbRemarque.Location = new System.Drawing.Point(149, 374);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(200, 20);
            this.tbRemarque.TabIndex = 32;
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataMember = "Provinces";
            this.provincesBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // provincesTableAdapter
            // 
            this.provincesTableAdapter.ClearBeforeFill = true;
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(149, 243);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(139, 21);
            this.cbProvince.TabIndex = 32;
            this.cbProvince.ValueMember = "Id";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataMember = "TypesAbonnement";
            this.typesAbonnementBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // typesAbonnementTableAdapter
            // 
            this.typesAbonnementTableAdapter.ClearBeforeFill = true;
            // 
            // typesAbonnementBindingSource1
            // 
            this.typesAbonnementBindingSource1.DataMember = "TypesAbonnement";
            this.typesAbonnementBindingSource1.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // lbTypeAbonnement
            // 
            this.lbTypeAbonnement.DataSource = this.typesAbonnementBindingSource1;
            this.lbTypeAbonnement.DisplayMember = "Description";
            this.lbTypeAbonnement.FormattingEnabled = true;
            this.lbTypeAbonnement.Location = new System.Drawing.Point(407, 65);
            this.lbTypeAbonnement.Name = "lbTypeAbonnement";
            this.lbTypeAbonnement.Size = new System.Drawing.Size(154, 212);
            this.lbTypeAbonnement.TabIndex = 32;
            this.lbTypeAbonnement.ValueMember = "No";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(149, 296);
            this.tbTelephone.Mask = "0000000000";
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.ResetOnSpace = false;
            this.tbTelephone.Size = new System.Drawing.Size(139, 20);
            this.tbTelephone.TabIndex = 33;
            // 
            // tbCellulaire
            // 
            this.tbCellulaire.Location = new System.Drawing.Point(149, 322);
            this.tbCellulaire.Mask = "0000000000";
            this.tbCellulaire.Name = "tbCellulaire";
            this.tbCellulaire.ResetOnSpace = false;
            this.tbCellulaire.Size = new System.Drawing.Size(139, 20);
            this.tbCellulaire.TabIndex = 34;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.AsciiOnly = true;
            this.tbCodePostal.Location = new System.Drawing.Point(149, 270);
            this.tbCodePostal.Mask = " >L0L0L0";
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.ResetOnPrompt = false;
            this.tbCodePostal.ResetOnSpace = false;
            this.tbCodePostal.Size = new System.Drawing.Size(139, 20);
            this.tbCodePostal.TabIndex = 35;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 440);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 36;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(559, 440);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 37;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cbSexe
            // 
            this.cbSexe.AutoCompleteCustomSource.AddRange(new string[] {
            "Homme",
            "Femme",
            "Ne préfère pas spécifier"});
            this.cbSexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Ne préfère pas spécifier"});
            this.cbSexe.Location = new System.Drawing.Point(149, 113);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(139, 21);
            this.cbSexe.TabIndex = 38;
            this.cbSexe.Text = "Homme";
            // 
            // messageErreur
            // 
            this.messageErreur.ContainerControl = this;
            // 
            // numNoCivique
            // 
            this.numNoCivique.Location = new System.Drawing.Point(149, 166);
            this.numNoCivique.Name = "numNoCivique";
            this.numNoCivique.Size = new System.Drawing.Size(200, 20);
            this.numNoCivique.TabIndex = 39;
            // 
            // Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 475);
            this.Controls.Add(this.numNoCivique);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.tbCellulaire);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.lbTypeAbonnement);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dtDateNaissance);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(noTypeAbonnementLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.tbRemarque);
            this.Name = "Abonnement";
            this.Text = "Abonnement";
            this.Load += new System.EventHandler(this.Abonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.DateTimePicker dtDateNaissance;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbRemarque;
        private BDB56Projet2GSDataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.TypesAbonnementTableAdapter typesAbonnementTableAdapter;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource1;
        private System.Windows.Forms.ListBox lbTypeAbonnement;
        private System.Windows.Forms.MaskedTextBox tbTelephone;
        private System.Windows.Forms.MaskedTextBox tbCellulaire;
        private System.Windows.Forms.MaskedTextBox tbCodePostal;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.ErrorProvider messageErreur;
        private System.Windows.Forms.NumericUpDown numNoCivique;
    }
}