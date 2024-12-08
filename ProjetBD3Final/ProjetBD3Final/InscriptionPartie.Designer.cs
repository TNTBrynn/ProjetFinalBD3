namespace ProjetBD3Final
{
    partial class InscriptionPartie
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
            System.Windows.Forms.Label idAbonnementLabel;
            System.Windows.Forms.Label noTerrainLabel;
            System.Windows.Forms.Label pointageLabel;
            System.Windows.Forms.Label remarqueLabel;
            this.dgAbonnement = new System.Windows.Forms.DataGridView();
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.partiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiesJoueesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.PartiesJoueesTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.numPointage = new System.Windows.Forms.NumericUpDown();
            this.messageErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.terrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terrainsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TerrainsTableAdapter();
            this.cbTerrain = new System.Windows.Forms.ComboBox();
            idAbonnementLabel = new System.Windows.Forms.Label();
            noTerrainLabel = new System.Windows.Forms.Label();
            pointageLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAbonnement
            // 
            this.dgAbonnement.AllowUserToAddRows = false;
            this.dgAbonnement.AllowUserToDeleteRows = false;
            this.dgAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnement.Location = new System.Drawing.Point(12, 12);
            this.dgAbonnement.MultiSelect = false;
            this.dgAbonnement.Name = "dgAbonnement";
            this.dgAbonnement.ReadOnly = true;
            this.dgAbonnement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnement.Size = new System.Drawing.Size(427, 150);
            this.dgAbonnement.TabIndex = 1;
            this.dgAbonnement.SelectionChanged += new System.EventHandler(this.dgAbonnement_SelectionChanged);
            // 
            // bDB56Projet2GSDataSet
            // 
            this.bDB56Projet2GSDataSet.DataSetName = "BDB56Projet2GSDataSet";
            this.bDB56Projet2GSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partiesJoueesBindingSource
            // 
            this.partiesJoueesBindingSource.DataMember = "PartiesJouees";
            this.partiesJoueesBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // partiesJoueesTableAdapter
            // 
            this.partiesJoueesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = this.partiesJoueesTableAdapter;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = this.terrainsTableAdapter;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Location = new System.Drawing.Point(12, 181);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(82, 13);
            idAbonnementLabel.TabIndex = 2;
            idAbonnementLabel.Text = "Id Abonnement:";
            // 
            // tbId
            // 
            this.tbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "IdAbonnement", true));
            this.tbId.Location = new System.Drawing.Point(100, 178);
            this.tbId.MaxLength = 50;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(200, 20);
            this.tbId.TabIndex = 3;
            // 
            // noTerrainLabel
            // 
            noTerrainLabel.AutoSize = true;
            noTerrainLabel.Location = new System.Drawing.Point(12, 207);
            noTerrainLabel.Name = "noTerrainLabel";
            noTerrainLabel.Size = new System.Drawing.Size(43, 13);
            noTerrainLabel.TabIndex = 4;
            noTerrainLabel.Text = "Terrain:";
            // 
            // pointageLabel
            // 
            pointageLabel.AutoSize = true;
            pointageLabel.Location = new System.Drawing.Point(12, 233);
            pointageLabel.Name = "pointageLabel";
            pointageLabel.Size = new System.Drawing.Size(52, 13);
            pointageLabel.TabIndex = 8;
            pointageLabel.Text = "Pointage:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(12, 259);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 10;
            remarqueLabel.Text = "Remarque:";
            // 
            // tbRemarque
            // 
            this.tbRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "Remarque", true));
            this.tbRemarque.Location = new System.Drawing.Point(100, 256);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(200, 20);
            this.tbRemarque.TabIndex = 11;
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(12, 415);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(75, 23);
            this.btnInscrire.TabIndex = 12;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(488, 415);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // numPointage
            // 
            this.numPointage.Location = new System.Drawing.Point(100, 230);
            this.numPointage.Name = "numPointage";
            this.numPointage.Size = new System.Drawing.Size(120, 20);
            this.numPointage.TabIndex = 14;
            // 
            // messageErreur
            // 
            this.messageErreur.ContainerControl = this;
            // 
            // terrainsBindingSource
            // 
            this.terrainsBindingSource.DataMember = "Terrains";
            this.terrainsBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // terrainsTableAdapter
            // 
            this.terrainsTableAdapter.ClearBeforeFill = true;
            // 
            // cbTerrain
            // 
            this.cbTerrain.DataSource = this.terrainsBindingSource;
            this.cbTerrain.DisplayMember = "Nom";
            this.cbTerrain.FormattingEnabled = true;
            this.cbTerrain.Location = new System.Drawing.Point(100, 207);
            this.cbTerrain.Name = "cbTerrain";
            this.cbTerrain.Size = new System.Drawing.Size(200, 21);
            this.cbTerrain.TabIndex = 15;
            this.cbTerrain.ValueMember = "No";
            // 
            // InscriptionPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 458);
            this.Controls.Add(this.cbTerrain);
            this.Controls.Add(this.numPointage);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(idAbonnementLabel);
            this.Controls.Add(this.tbId);
            this.Controls.Add(noTerrainLabel);
            this.Controls.Add(pointageLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.dgAbonnement);
            this.Name = "InscriptionPartie";
            this.Text = "InscriptionPartie";
            this.Load += new System.EventHandler(this.InscriptionPartie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAbonnement;
        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource partiesJoueesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.PartiesJoueesTableAdapter partiesJoueesTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.NumericUpDown numPointage;
        private System.Windows.Forms.ErrorProvider messageErreur;
        private BDB56Projet2GSDataSetTableAdapters.TerrainsTableAdapter terrainsTableAdapter;
        private System.Windows.Forms.BindingSource terrainsBindingSource;
        private System.Windows.Forms.ComboBox cbTerrain;
    }
}