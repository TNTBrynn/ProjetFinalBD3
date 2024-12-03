namespace ProjetBD3Final
{
    partial class AbonnementConjoint
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
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label sexeLabel;
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.DependantsTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.dtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.messageErreur = new System.Windows.Forms.ErrorProvider(this.components);
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageErreur)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(17, 26);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(17, 52);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 5;
            prenomLabel.Text = "Prenom:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(17, 105);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(86, 13);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(17, 130);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 13;
            remarqueLabel.Text = "Remarque:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(17, 78);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 7;
            sexeLabel.Text = "Sexe:";
            // 
            // bDB56Projet2GSDataSet
            // 
            this.bDB56Projet2GSDataSet.DataSetName = "BDB56Projet2GSDataSet";
            this.bDB56Projet2GSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataMember = "Dependants";
            this.dependantsBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // dependantsTableAdapter
            // 
            this.dependantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = this.dependantsTableAdapter;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
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
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Nom", true));
            this.tbNom.Location = new System.Drawing.Point(109, 23);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(200, 20);
            this.tbNom.TabIndex = 4;
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Prenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(109, 49);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(200, 20);
            this.tbPrenom.TabIndex = 6;
            // 
            // tbRemarque
            // 
            this.tbRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Remarque", true));
            this.tbRemarque.Location = new System.Drawing.Point(109, 127);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(200, 20);
            this.tbRemarque.TabIndex = 14;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 186);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(320, 186);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 16;
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
            this.cbSexe.Location = new System.Drawing.Point(109, 74);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(139, 21);
            this.cbSexe.TabIndex = 40;
            this.cbSexe.Text = "Homme";
            // 
            // dtDateNaissance
            // 
            this.dtDateNaissance.Location = new System.Drawing.Point(109, 101);
            this.dtDateNaissance.MaxDate = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            this.dtDateNaissance.Name = "dtDateNaissance";
            this.dtDateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dtDateNaissance.TabIndex = 41;
            this.dtDateNaissance.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            // 
            // messageErreur
            // 
            this.messageErreur.ContainerControl = this;
            // 
            // AbonnementConjoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 222);
            this.Controls.Add(this.dtDateNaissance);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.tbRemarque);
            this.Name = "AbonnementConjoint";
            this.Text = "AbonnementConjoint";
            this.Load += new System.EventHandler(this.AbonnementConjoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageErreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.DependantsTableAdapter dependantsTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.DateTimePicker dtDateNaissance;
        private System.Windows.Forms.ErrorProvider messageErreur;
    }
}