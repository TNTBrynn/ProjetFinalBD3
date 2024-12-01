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
            this.prixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.prixDepensesAbonnementsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.PrixDepensesAbonnementsTableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.dtTypeEtPrixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtTypeEtPrixDepensesAbonnementsTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.dtTypeEtPrixDepensesAbonnementsTableAdapter();
            this.dtTypeEtPrixDepensesAbonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTypeEtPrixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTypeEtPrixDepensesAbonnementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prixDepensesAbonnementsBindingSource
            // 
            this.prixDepensesAbonnementsBindingSource.DataMember = "PrixDepensesAbonnements";
            this.prixDepensesAbonnementsBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // bDB56Projet2GSDataSet
            // 
            this.bDB56Projet2GSDataSet.DataSetName = "BDB56Projet2GSDataSet";
            this.bDB56Projet2GSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dtTypeEtPrixDepensesAbonnementsBindingSource
            // 
            this.dtTypeEtPrixDepensesAbonnementsBindingSource.DataMember = "dtTypeEtPrixDepensesAbonnements";
            this.dtTypeEtPrixDepensesAbonnementsBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // dtTypeEtPrixDepensesAbonnementsTableAdapter
            // 
            this.dtTypeEtPrixDepensesAbonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // dtTypeEtPrixDepensesAbonnementsDataGridView
            // 
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.AllowUserToAddRows = false;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.AllowUserToDeleteRows = false;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.AutoGenerateColumns = false;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.DataSource = this.dtTypeEtPrixDepensesAbonnementsBindingSource;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.Location = new System.Drawing.Point(37, 26);
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.Name = "dtTypeEtPrixDepensesAbonnementsDataGridView";
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.RowHeadersWidth = 10;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.RowTemplate.Height = 24;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.Size = new System.Drawing.Size(684, 379);
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.TabIndex = 0;
            this.dtTypeEtPrixDepensesAbonnementsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTypeEtPrixDepensesAbonnementsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn3.HeaderText = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // GestionPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtTypeEtPrixDepensesAbonnementsDataGridView);
            this.Name = "GestionPrix";
            this.Text = "GestionPrix";
            this.Load += new System.EventHandler(this.GestionPrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTypeEtPrixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTypeEtPrixDepensesAbonnementsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource prixDepensesAbonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.PrixDepensesAbonnementsTableAdapter prixDepensesAbonnementsTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dtTypeEtPrixDepensesAbonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.dtTypeEtPrixDepensesAbonnementsTableAdapter dtTypeEtPrixDepensesAbonnementsTableAdapter;
        private System.Windows.Forms.DataGridView dtTypeEtPrixDepensesAbonnementsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}