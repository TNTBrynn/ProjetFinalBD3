namespace ProjetBD3Final
{
    partial class AjoutEmp
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
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label salaireHoraireLabel;
            System.Windows.Forms.Label noTypeEmployeLabel;
            System.Windows.Forms.Label remarqueLabel;
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.EmployesTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbSexe = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbNoCiv = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.tbCell = new System.Windows.Forms.MaskedTextBox();
            this.tbTel = new System.Windows.Forms.MaskedTextBox();
            this.tbCode = new System.Windows.Forms.MaskedTextBox();
            this.tbSalaire = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbProvinces = new System.Windows.Forms.ComboBox();
            noLabel = new System.Windows.Forms.Label();
            motDePasseLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            salaireHoraireLabel = new System.Windows.Forms.Label();
            noTypeEmployeLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(32, 37);
            noLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(97, 13);
            noLabel.TabIndex = 1;
            noLabel.Text = "Numéro d\'employé:";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(32, 60);
            motDePasseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(75, 13);
            motDePasseLabel.TabIndex = 3;
            motDePasseLabel.Text = "Mot de Passe:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(32, 83);
            nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(32, 106);
            prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 7;
            prenomLabel.Text = "Prenom:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(32, 128);
            sexeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 9;
            sexeLabel.Text = "Sexe:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(32, 151);
            ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(214, 37);
            noCiviqueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 13;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(214, 60);
            rueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 15;
            rueLabel.Text = "Rue:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(214, 83);
            villeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 17;
            villeLabel.Text = "Ville:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(214, 106);
            idProvinceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 19;
            idProvinceLabel.Text = "Province:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(214, 128);
            codePostalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 21;
            codePostalLabel.Text = "Code Postal:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(401, 34);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 23;
            telephoneLabel.Text = "Telephone:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(401, 57);
            cellulaireLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(52, 13);
            cellulaireLabel.TabIndex = 25;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(401, 80);
            courrielLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 27;
            courrielLabel.Text = "Courriel:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Location = new System.Drawing.Point(401, 102);
            salaireHoraireLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(79, 13);
            salaireHoraireLabel.TabIndex = 29;
            salaireHoraireLabel.Text = "Salaire Horaire:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Location = new System.Drawing.Point(401, 125);
            noTypeEmployeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(84, 13);
            noTypeEmployeLabel.TabIndex = 31;
            noTypeEmployeLabel.Text = "Type d\'employe:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(401, 148);
            remarqueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 33;
            remarqueLabel.Text = "Remarque:";
            // 
            // bDB56Projet2GSDataSet
            // 
            this.bDB56Projet2GSDataSet.DataSetName = "BDB56Projet2GSDataSet";
            this.bDB56Projet2GSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = this.employesTableAdapter;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "No", true));
            this.noTextBox.Enabled = false;
            this.noTextBox.Location = new System.Drawing.Point(126, 35);
            this.noTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(76, 20);
            this.noTextBox.TabIndex = 2;
            // 
            // tbMdp
            // 
            this.tbMdp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "MotDePasse", true));
            this.tbMdp.Location = new System.Drawing.Point(126, 58);
            this.tbMdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(76, 20);
            this.tbMdp.TabIndex = 4;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Nom", true));
            this.tbNom.Location = new System.Drawing.Point(126, 80);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(76, 20);
            this.tbNom.TabIndex = 6;
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Prenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(126, 103);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(76, 20);
            this.tbPrenom.TabIndex = 8;
            // 
            // tbSexe
            // 
            this.tbSexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Sexe", true));
            this.tbSexe.Location = new System.Drawing.Point(126, 126);
            this.tbSexe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSexe.MaxLength = 1;
            this.tbSexe.Name = "tbSexe";
            this.tbSexe.Size = new System.Drawing.Size(76, 20);
            this.tbSexe.TabIndex = 10;
            // 
            // tbAge
            // 
            this.tbAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Age", true));
            this.tbAge.Location = new System.Drawing.Point(126, 149);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(76, 20);
            this.tbAge.TabIndex = 12;
            // 
            // tbNoCiv
            // 
            this.tbNoCiv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoCivique", true));
            this.tbNoCiv.Location = new System.Drawing.Point(308, 35);
            this.tbNoCiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNoCiv.Name = "tbNoCiv";
            this.tbNoCiv.Size = new System.Drawing.Size(76, 20);
            this.tbNoCiv.TabIndex = 14;
            // 
            // tbRue
            // 
            this.tbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Rue", true));
            this.tbRue.Location = new System.Drawing.Point(308, 58);
            this.tbRue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(76, 20);
            this.tbRue.TabIndex = 16;
            // 
            // tbVille
            // 
            this.tbVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Ville", true));
            this.tbVille.Location = new System.Drawing.Point(308, 80);
            this.tbVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(76, 20);
            this.tbVille.TabIndex = 18;
            this.tbVille.TextChanged += new System.EventHandler(this.tbVille_TextChanged);
            // 
            // tbCourriel
            // 
            this.tbCourriel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Courriel", true));
            this.tbCourriel.Location = new System.Drawing.Point(496, 77);
            this.tbCourriel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(76, 20);
            this.tbCourriel.TabIndex = 28;
            // 
            // tbRemarque
            // 
            this.tbRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Remarque", true));
            this.tbRemarque.Location = new System.Drawing.Point(496, 145);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(123, 20);
            this.tbRemarque.TabIndex = 34;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(75, 229);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(126, 45);
            this.btnAjout.TabIndex = 35;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(496, 57);
            this.tbCell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCell.Mask = "(000) 000-0000";
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(76, 20);
            this.tbCell.TabIndex = 36;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(496, 34);
            this.tbTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTel.Mask = "(000) 000-0000";
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(76, 20);
            this.tbTel.TabIndex = 37;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(308, 126);
            this.tbCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCode.Mask = ">L0L0L0";
            this.tbCode.Name = "tbCode";
            this.tbCode.PromptChar = ' ';
            this.tbCode.Size = new System.Drawing.Size(76, 20);
            this.tbCode.TabIndex = 40;
            this.tbCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbSalaire
            // 
            this.tbSalaire.Location = new System.Drawing.Point(496, 101);
            this.tbSalaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSalaire.Name = "tbSalaire";
            this.tbSalaire.Size = new System.Drawing.Size(76, 20);
            this.tbSalaire.TabIndex = 41;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(404, 229);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(126, 43);
            this.btnRetour.TabIndex = 42;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(496, 122);
            this.cbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(123, 21);
            this.cbType.TabIndex = 43;
            // 
            // cbProvinces
            // 
            this.cbProvinces.FormattingEnabled = true;
            this.cbProvinces.Location = new System.Drawing.Point(308, 103);
            this.cbProvinces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProvinces.Name = "cbProvinces";
            this.cbProvinces.Size = new System.Drawing.Size(76, 21);
            this.cbProvinces.TabIndex = 44;
            // 
            // AjoutEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 323);
            this.Controls.Add(this.cbProvinces);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.tbSalaire);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbCell);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(this.tbSexe);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.tbNoCiv);
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
            this.Controls.Add(salaireHoraireLabel);
            this.Controls.Add(noTypeEmployeLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.tbRemarque);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjoutEmp";
            this.Text = "Ajouter un employé";
            this.Load += new System.EventHandler(this.AjoutEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbSexe;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbNoCiv;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.MaskedTextBox tbCell;
        private System.Windows.Forms.MaskedTextBox tbTel;
        private System.Windows.Forms.MaskedTextBox tbCode;

        private System.Windows.Forms.TextBox tbSalaire;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbProvinces;
    }
}