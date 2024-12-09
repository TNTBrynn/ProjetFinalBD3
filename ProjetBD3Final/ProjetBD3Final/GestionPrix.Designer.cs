namespace ProjetBD3Final
{
    partial class GestionPrix
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
            this.dgPrix = new System.Windows.Forms.DataGridView();
            this.dtTypeEtPrixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.prixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixDepensesAbonnementsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.PrixDepensesAbonnementsTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.dtTypeEtPrixDepensesAbonnementsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.dtTypeEtPrixDepensesAbonnementsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepensesObligatoires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTypeEtPrixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPrix
            // 
            this.dgPrix.AllowUserToAddRows = false;
            this.dgPrix.AllowUserToDeleteRows = false;
            this.dgPrix.AutoGenerateColumns = false;
            this.dgPrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.DepensesObligatoires,
            this.Annee,
            this.Id});
            this.dgPrix.DataSource = this.dtTypeEtPrixDepensesAbonnementsBindingSource;
            this.dgPrix.Location = new System.Drawing.Point(49, 43);
            this.dgPrix.Name = "dgPrix";
            this.dgPrix.RowHeadersWidth = 10;
            this.dgPrix.RowTemplate.Height = 24;
            this.dgPrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrix.Size = new System.Drawing.Size(674, 290);
            this.dgPrix.TabIndex = 0;
            // 
            // dtTypeEtPrixDepensesAbonnementsBindingSource
            // 
            this.dtTypeEtPrixDepensesAbonnementsBindingSource.DataMember = "dtTypeEtPrixDepensesAbonnements";
            this.dtTypeEtPrixDepensesAbonnementsBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // bDB56Projet2GSDataSet
            // 
            this.bDB56Projet2GSDataSet.DataSetName = "BDB56Projet2GSDataSet";
            this.bDB56Projet2GSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prixDepensesAbonnementsBindingSource
            // 
            this.prixDepensesAbonnementsBindingSource.DataMember = "PrixDepensesAbonnements";
            this.prixDepensesAbonnementsBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // prixDepensesAbonnementsTableAdapter
            // 
            this.prixDepensesAbonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = this.prixDepensesAbonnementsTableAdapter;
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtTypeEtPrixDepensesAbonnementsTableAdapter
            // 
            this.dtTypeEtPrixDepensesAbonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // DepensesObligatoires
            // 
            this.DepensesObligatoires.DataPropertyName = "DepensesObligatoires";
            this.DepensesObligatoires.HeaderText = "DepensesObligatoires";
            this.DepensesObligatoires.MinimumWidth = 6;
            this.DepensesObligatoires.Name = "DepensesObligatoires";
            // 
            // Annee
            // 
            this.Annee.DataPropertyName = "Annee";
            this.Annee.HeaderText = "Annee";
            this.Annee.MinimumWidth = 6;
            this.Annee.Name = "Annee";
            this.Annee.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "NoTypeAbonnement";
            this.Id.HeaderText = "NoTypeAbonnement";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // GestionPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPrix);
            this.Name = "GestionPrix";
            this.Text = "GestionPrix";
            this.Load += new System.EventHandler(this.GestionPrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTypeEtPrixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource prixDepensesAbonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.PrixDepensesAbonnementsTableAdapter prixDepensesAbonnementsTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dtTypeEtPrixDepensesAbonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.dtTypeEtPrixDepensesAbonnementsTableAdapter dtTypeEtPrixDepensesAbonnementsTableAdapter;
        private System.Windows.Forms.DataGridView dgPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepensesObligatoires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}