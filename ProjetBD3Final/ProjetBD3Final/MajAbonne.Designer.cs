namespace ProjetBD3Final
{
    partial class MajAbonne
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
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.AbonnementsTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.dependantsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.DependantsTableAdapter();
            this.reabonnementsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.ReabonnementsTableAdapter();
            this.dgAbonnements = new System.Windows.Forms.DataGridView();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reabonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgDependants = new System.Windows.Forms.DataGridView();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.provincesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.ProvincesTableAdapter();
            this.dgTxtIdDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNomDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrenomDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtSexeDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDateNaissanceDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtIdAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtRemarqueDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDateAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoCivique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtIdProvince = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgTxtCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtCellulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoTypeAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).BeginInit();
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
            this.tableAdapterManager.DependantsTableAdapter = this.dependantsTableAdapter;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = this.reabonnementsTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dependantsTableAdapter
            // 
            this.dependantsTableAdapter.ClearBeforeFill = true;
            // 
            // reabonnementsTableAdapter
            // 
            this.reabonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // dgAbonnements
            // 
            this.dgAbonnements.AllowUserToAddRows = false;
            this.dgAbonnements.AllowUserToDeleteRows = false;
            this.dgAbonnements.AllowUserToResizeRows = false;
            this.dgAbonnements.AutoGenerateColumns = false;
            this.dgAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtId,
            this.dgTxtDateAbonnement,
            this.dgTxtNom,
            this.dgTxtPrenom,
            this.dgTxtSexe,
            this.dgTxtDateNaissance,
            this.dgTxtNoCivique,
            this.dgTxtRue,
            this.dgTxtVille,
            this.dgTxtIdProvince,
            this.dgTxtCodePostal,
            this.dgTxtTelephone,
            this.dgTxtCellulaire,
            this.dgTxtCourriel,
            this.dgTxtNoTypeAbonnement,
            this.dgTxtRemarque});
            this.dgAbonnements.DataSource = this.abonnementsBindingSource;
            this.dgAbonnements.Location = new System.Drawing.Point(12, 12);
            this.dgAbonnements.MultiSelect = false;
            this.dgAbonnements.Name = "dgAbonnements";
            this.dgAbonnements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnements.Size = new System.Drawing.Size(1278, 220);
            this.dgAbonnements.TabIndex = 1;
            this.dgAbonnements.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgAbonnements_DataError);
            this.dgAbonnements.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgAbonnements_RowValidating);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataMember = "Provinces";
            this.provincesBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // reabonnementsBindingSource
            // 
            this.reabonnementsBindingSource.DataMember = "FK__Reabonnem__IdAbo__571DF1D5";
            this.reabonnementsBindingSource.DataSource = this.abonnementsBindingSource;
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataMember = "FK__Dependant__IdAbo__47DBAE45";
            this.dependantsBindingSource.DataSource = this.abonnementsBindingSource;
            // 
            // dgDependants
            // 
            this.dgDependants.AllowUserToAddRows = false;
            this.dgDependants.AllowUserToDeleteRows = false;
            this.dgDependants.AutoGenerateColumns = false;
            this.dgDependants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDependants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDependants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtIdDependant,
            this.dgTxtNomDependant,
            this.dgTxtPrenomDependant,
            this.dgTxtSexeDependant,
            this.dgTxtDateNaissanceDependant,
            this.dgTxtIdAbonnement,
            this.dgTxtRemarqueDependant});
            this.dgDependants.DataSource = this.dependantsBindingSource;
            this.dgDependants.Location = new System.Drawing.Point(12, 238);
            this.dgDependants.MultiSelect = false;
            this.dgDependants.Name = "dgDependants";
            this.dgDependants.Size = new System.Drawing.Size(909, 220);
            this.dgDependants.TabIndex = 1;
            this.dgDependants.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgDependants_DataError);
            this.dgDependants.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDependants_RowValidating);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 544);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(1214, 544);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // provincesTableAdapter
            // 
            this.provincesTableAdapter.ClearBeforeFill = true;
            // 
            // dgTxtIdDependant
            // 
            this.dgTxtIdDependant.DataPropertyName = "Id";
            this.dgTxtIdDependant.HeaderText = "Id";
            this.dgTxtIdDependant.Name = "dgTxtIdDependant";
            this.dgTxtIdDependant.ReadOnly = true;
            // 
            // dgTxtNomDependant
            // 
            this.dgTxtNomDependant.DataPropertyName = "Nom";
            this.dgTxtNomDependant.HeaderText = "Nom";
            this.dgTxtNomDependant.MaxInputLength = 50;
            this.dgTxtNomDependant.Name = "dgTxtNomDependant";
            // 
            // dgTxtPrenomDependant
            // 
            this.dgTxtPrenomDependant.DataPropertyName = "Prenom";
            this.dgTxtPrenomDependant.HeaderText = "Prenom";
            this.dgTxtPrenomDependant.MaxInputLength = 50;
            this.dgTxtPrenomDependant.Name = "dgTxtPrenomDependant";
            // 
            // dgTxtSexeDependant
            // 
            this.dgTxtSexeDependant.DataPropertyName = "Sexe";
            this.dgTxtSexeDependant.HeaderText = "Sexe";
            this.dgTxtSexeDependant.MaxInputLength = 1;
            this.dgTxtSexeDependant.Name = "dgTxtSexeDependant";
            // 
            // dgTxtDateNaissanceDependant
            // 
            this.dgTxtDateNaissanceDependant.DataPropertyName = "DateNaissance";
            this.dgTxtDateNaissanceDependant.HeaderText = "DateNaissance";
            this.dgTxtDateNaissanceDependant.Name = "dgTxtDateNaissanceDependant";
            this.dgTxtDateNaissanceDependant.ReadOnly = true;
            // 
            // dgTxtIdAbonnement
            // 
            this.dgTxtIdAbonnement.DataPropertyName = "IdAbonnement";
            this.dgTxtIdAbonnement.HeaderText = "IdAbonnement";
            this.dgTxtIdAbonnement.Name = "dgTxtIdAbonnement";
            this.dgTxtIdAbonnement.ReadOnly = true;
            // 
            // dgTxtRemarqueDependant
            // 
            this.dgTxtRemarqueDependant.DataPropertyName = "Remarque";
            this.dgTxtRemarqueDependant.HeaderText = "Remarque";
            this.dgTxtRemarqueDependant.Name = "dgTxtRemarqueDependant";
            // 
            // dgTxtId
            // 
            this.dgTxtId.DataPropertyName = "Id";
            this.dgTxtId.HeaderText = "Id";
            this.dgTxtId.Name = "dgTxtId";
            this.dgTxtId.ReadOnly = true;
            // 
            // dgTxtDateAbonnement
            // 
            this.dgTxtDateAbonnement.DataPropertyName = "DateAbonnement";
            this.dgTxtDateAbonnement.HeaderText = "DateAbonnement";
            this.dgTxtDateAbonnement.Name = "dgTxtDateAbonnement";
            this.dgTxtDateAbonnement.ReadOnly = true;
            // 
            // dgTxtNom
            // 
            this.dgTxtNom.DataPropertyName = "Nom";
            this.dgTxtNom.HeaderText = "Nom";
            this.dgTxtNom.MaxInputLength = 50;
            this.dgTxtNom.Name = "dgTxtNom";
            this.dgTxtNom.ReadOnly = true;
            // 
            // dgTxtPrenom
            // 
            this.dgTxtPrenom.DataPropertyName = "Prenom";
            this.dgTxtPrenom.HeaderText = "Prenom";
            this.dgTxtPrenom.MaxInputLength = 50;
            this.dgTxtPrenom.Name = "dgTxtPrenom";
            // 
            // dgTxtSexe
            // 
            this.dgTxtSexe.DataPropertyName = "Sexe";
            this.dgTxtSexe.HeaderText = "Sexe";
            this.dgTxtSexe.MaxInputLength = 1;
            this.dgTxtSexe.Name = "dgTxtSexe";
            // 
            // dgTxtDateNaissance
            // 
            this.dgTxtDateNaissance.DataPropertyName = "DateNaissance";
            this.dgTxtDateNaissance.HeaderText = "DateNaissance";
            this.dgTxtDateNaissance.Name = "dgTxtDateNaissance";
            this.dgTxtDateNaissance.ReadOnly = true;
            // 
            // dgTxtNoCivique
            // 
            this.dgTxtNoCivique.DataPropertyName = "NoCivique";
            this.dgTxtNoCivique.HeaderText = "NoCivique";
            this.dgTxtNoCivique.MaxInputLength = 6;
            this.dgTxtNoCivique.Name = "dgTxtNoCivique";
            // 
            // dgTxtRue
            // 
            this.dgTxtRue.DataPropertyName = "Rue";
            this.dgTxtRue.HeaderText = "Rue";
            this.dgTxtRue.Name = "dgTxtRue";
            // 
            // dgTxtVille
            // 
            this.dgTxtVille.DataPropertyName = "Ville";
            this.dgTxtVille.HeaderText = "Ville";
            this.dgTxtVille.Name = "dgTxtVille";
            // 
            // dgTxtIdProvince
            // 
            this.dgTxtIdProvince.DataPropertyName = "IdProvince";
            this.dgTxtIdProvince.DataSource = this.provincesBindingSource;
            this.dgTxtIdProvince.DisplayMember = "Nom";
            this.dgTxtIdProvince.HeaderText = "IdProvince";
            this.dgTxtIdProvince.Name = "dgTxtIdProvince";
            this.dgTxtIdProvince.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTxtIdProvince.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTxtIdProvince.ValueMember = "Id";
            // 
            // dgTxtCodePostal
            // 
            this.dgTxtCodePostal.DataPropertyName = "CodePostal";
            this.dgTxtCodePostal.HeaderText = "CodePostal";
            this.dgTxtCodePostal.Name = "dgTxtCodePostal";
            // 
            // dgTxtTelephone
            // 
            this.dgTxtTelephone.DataPropertyName = "Telephone";
            this.dgTxtTelephone.HeaderText = "Telephone";
            this.dgTxtTelephone.Name = "dgTxtTelephone";
            // 
            // dgTxtCellulaire
            // 
            this.dgTxtCellulaire.DataPropertyName = "Cellulaire";
            this.dgTxtCellulaire.HeaderText = "Cellulaire";
            this.dgTxtCellulaire.Name = "dgTxtCellulaire";
            // 
            // dgTxtCourriel
            // 
            this.dgTxtCourriel.DataPropertyName = "Courriel";
            this.dgTxtCourriel.HeaderText = "Courriel";
            this.dgTxtCourriel.Name = "dgTxtCourriel";
            // 
            // dgTxtNoTypeAbonnement
            // 
            this.dgTxtNoTypeAbonnement.DataPropertyName = "NoTypeAbonnement";
            this.dgTxtNoTypeAbonnement.HeaderText = "NoTypeAbonnement";
            this.dgTxtNoTypeAbonnement.Name = "dgTxtNoTypeAbonnement";
            this.dgTxtNoTypeAbonnement.ReadOnly = true;
            // 
            // dgTxtRemarque
            // 
            this.dgTxtRemarque.DataPropertyName = "Remarque";
            this.dgTxtRemarque.HeaderText = "Remarque";
            this.dgTxtRemarque.Name = "dgTxtRemarque";
            // 
            // MajAbonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 579);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgDependants);
            this.Controls.Add(this.dgAbonnements);
            this.Name = "MajAbonne";
            this.Text = "Mise à jour des abonnés";
            this.Load += new System.EventHandler(this.MajAbonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDB56Projet2GSDataSetTableAdapters.ReabonnementsTableAdapter reabonnementsTableAdapter;
        private System.Windows.Forms.DataGridView dgAbonnements;
        private System.Windows.Forms.BindingSource reabonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.DependantsTableAdapter dependantsTableAdapter;
        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.DataGridView dgDependants;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtIdDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNomDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrenomDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtSexeDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateNaissanceDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtIdAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtRemarqueDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoCivique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtVille;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTxtIdProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtCellulaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtCourriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoTypeAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtRemarque;
    }
}