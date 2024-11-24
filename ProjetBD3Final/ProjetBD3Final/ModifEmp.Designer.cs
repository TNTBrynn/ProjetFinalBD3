namespace ProjetBD3Final
{
    partial class ModifEmp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.EmployesTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.tbNoCiv = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbSexe = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSalaire = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.MaskedTextBox();
            this.tbCell = new System.Windows.Forms.MaskedTextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.MaskedTextBox();
            this.tbProvince = new System.Windows.Forms.MaskedTextBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(76, 40);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(28, 16);
            noLabel.TabIndex = 3;
            noLabel.Text = "No:";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(76, 68);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(95, 16);
            motDePasseLabel.TabIndex = 5;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(76, 96);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(39, 16);
            nomLabel.TabIndex = 7;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(76, 124);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(57, 16);
            prenomLabel.TabIndex = 9;
            prenomLabel.Text = "Prenom:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(76, 152);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(41, 16);
            sexeLabel.TabIndex = 11;
            sexeLabel.Text = "Sexe:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(76, 180);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(35, 16);
            ageLabel.TabIndex = 13;
            ageLabel.Text = "Age:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(76, 208);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(76, 16);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(76, 236);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(35, 16);
            rueLabel.TabIndex = 17;
            rueLabel.Text = "Rue:";
            // 
            // tbRue
            // 
            this.tbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Rue", true));
            this.tbRue.Location = new System.Drawing.Point(202, 233);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(100, 22);
            this.tbRue.TabIndex = 18;
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(76, 264);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(36, 16);
            villeLabel.TabIndex = 19;
            villeLabel.Text = "Ville:";
            // 
            // tbVille
            // 
            this.tbVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Ville", true));
            this.tbVille.Location = new System.Drawing.Point(202, 261);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(100, 22);
            this.tbVille.TabIndex = 20;
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(76, 292);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(77, 16);
            idProvinceLabel.TabIndex = 21;
            idProvinceLabel.Text = "Id Province:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(76, 320);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(84, 16);
            codePostalLabel.TabIndex = 23;
            codePostalLabel.Text = "Code Postal:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(76, 348);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(76, 16);
            telephoneLabel.TabIndex = 25;
            telephoneLabel.Text = "Telephone:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(76, 376);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(66, 16);
            cellulaireLabel.TabIndex = 27;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(76, 404);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(56, 16);
            courrielLabel.TabIndex = 29;
            courrielLabel.Text = "Courriel:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Location = new System.Drawing.Point(76, 432);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(101, 16);
            salaireHoraireLabel.TabIndex = 31;
            salaireHoraireLabel.Text = "Salaire Horaire:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Location = new System.Drawing.Point(76, 460);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(120, 16);
            noTypeEmployeLabel.TabIndex = 33;
            noTypeEmployeLabel.Text = "No Type Employe:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(76, 488);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(74, 16);
            remarqueLabel.TabIndex = 35;
            remarqueLabel.Text = "Remarque:";
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "No", true));
            this.noTextBox.Enabled = false;
            this.noTextBox.Location = new System.Drawing.Point(202, 37);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(100, 22);
            this.noTextBox.TabIndex = 37;
            // 
            // tbNoCiv
            // 
            this.tbNoCiv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoCivique", true));
            this.tbNoCiv.Location = new System.Drawing.Point(202, 205);
            this.tbNoCiv.Name = "tbNoCiv";
            this.tbNoCiv.Size = new System.Drawing.Size(100, 22);
            this.tbNoCiv.TabIndex = 43;
            // 
            // tbMdp
            // 
            this.tbMdp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "MotDePasse", true));
            this.tbMdp.Location = new System.Drawing.Point(202, 65);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(100, 22);
            this.tbMdp.TabIndex = 44;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Nom", true));
            this.tbNom.Location = new System.Drawing.Point(202, 93);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 22);
            this.tbNom.TabIndex = 45;
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Prenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(202, 121);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 22);
            this.tbPrenom.TabIndex = 46;
            // 
            // tbSexe
            // 
            this.tbSexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Sexe", true));
            this.tbSexe.Location = new System.Drawing.Point(202, 149);
            this.tbSexe.Name = "tbSexe";
            this.tbSexe.Size = new System.Drawing.Size(100, 22);
            this.tbSexe.TabIndex = 47;
            // 
            // tbAge
            // 
            this.tbAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Age", true));
            this.tbAge.Location = new System.Drawing.Point(202, 177);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 48;
            // 
            // tbSalaire
            // 
            this.tbSalaire.Location = new System.Drawing.Point(202, 430);
            this.tbSalaire.Name = "tbSalaire";
            this.tbSalaire.Size = new System.Drawing.Size(100, 22);
            this.tbSalaire.TabIndex = 54;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(202, 348);
            this.tbTel.Mask = "(000) 000-0000";
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 22);
            this.tbTel.TabIndex = 53;
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(202, 376);
            this.tbCell.Mask = "(000) 000-0000";
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(100, 22);
            this.tbCell.TabIndex = 52;
            // 
            // tbCourriel
            // 
            this.tbCourriel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Courriel", true));
            this.tbCourriel.Location = new System.Drawing.Point(202, 401);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(100, 22);
            this.tbCourriel.TabIndex = 49;
            // 
            // tbType
            // 
            this.tbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoTypeEmploye", true));
            this.tbType.Enabled = false;
            this.tbType.Location = new System.Drawing.Point(202, 457);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 22);
            this.tbType.TabIndex = 50;
            this.tbType.Text = "2";
            // 
            // tbRemarque
            // 
            this.tbRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Remarque", true));
            this.tbRemarque.Location = new System.Drawing.Point(202, 485);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(163, 22);
            this.tbRemarque.TabIndex = 51;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(202, 317);
            this.tbCode.Mask = ">A0A 0A0";
            this.tbCode.Name = "tbCode";
            this.tbCode.PromptChar = ' ';
            this.tbCode.Size = new System.Drawing.Size(100, 22);
            this.tbCode.TabIndex = 56;
            this.tbCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbProvince
            // 
            this.tbProvince.Location = new System.Drawing.Point(202, 289);
            this.tbProvince.Mask = ">LL";
            this.tbProvince.Name = "tbProvince";
            this.tbProvince.PromptChar = ' ';
            this.tbProvince.Size = new System.Drawing.Size(100, 22);
            this.tbProvince.TabIndex = 55;
            // 
            // ModifEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 527);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbProvince);
            this.Controls.Add(this.tbSalaire);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbCell);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbSexe);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbNoCiv);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(nomLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(ageLabel);
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
            this.Controls.Add(salaireHoraireLabel);
            this.Controls.Add(noTypeEmployeLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ModifEmp";
            this.Text = "Modification d\'un employé";
            this.Load += new System.EventHandler(this.ModifEmp_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox tbNoCiv;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbSexe;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSalaire;
        private System.Windows.Forms.MaskedTextBox tbTel;
        private System.Windows.Forms.MaskedTextBox tbCell;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.MaskedTextBox tbCode;
        private System.Windows.Forms.MaskedTextBox tbProvince;
    }
}