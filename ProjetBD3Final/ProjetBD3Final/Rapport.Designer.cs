namespace ProjetBD3Final
{
    partial class Rapport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgEmployes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.NomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.dataTable2TableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.DataTable2TableAdapter();
            this.dgDepenses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCompletE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dgDepenses);
            this.tabPage1.Controls.Add(this.dgEmployes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "dépenses par employés";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgEmployes
            // 
            this.dgEmployes.AllowUserToAddRows = false;
            this.dgEmployes.AutoGenerateColumns = false;
            this.dgEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomComplet});
            this.dgEmployes.DataSource = this.dataTable2BindingSource;
            this.dgEmployes.Location = new System.Drawing.Point(20, 26);
            this.dgEmployes.Name = "dgEmployes";
            this.dgEmployes.ReadOnly = true;
            this.dgEmployes.RowHeadersWidth = 10;
            this.dgEmployes.RowTemplate.Height = 24;
            this.dgEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployes.Size = new System.Drawing.Size(263, 347);
            this.dgEmployes.TabIndex = 0;
            this.dgEmployes.SelectionChanged += new System.EventHandler(this.dgEmployes_SelectionChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "dépenses par abonnement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(839, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "dépenses par année";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // bDB56Projet2GSDataSet
            // 
            this.bDB56Projet2GSDataSet.DataSetName = "BDB56Projet2GSDataSet";
            this.bDB56Projet2GSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NomComplet
            // 
            this.NomComplet.DataPropertyName = "NomComplet";
            this.NomComplet.HeaderText = "Nom Complet";
            this.NomComplet.MinimumWidth = 6;
            this.NomComplet.Name = "NomComplet";
            this.NomComplet.ReadOnly = true;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DependantsTableAdapter = null;
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
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // dgDepenses
            // 
            this.dgDepenses.AllowUserToAddRows = false;
            this.dgDepenses.AllowUserToDeleteRows = false;
            this.dgDepenses.AutoGenerateColumns = false;
            this.dgDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.NomCompletE,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgDepenses.DataSource = this.dataTable1BindingSource;
            this.dgDepenses.Location = new System.Drawing.Point(322, 26);
            this.dgDepenses.Name = "dgDepenses";
            this.dgDepenses.ReadOnly = true;
            this.dgDepenses.RowHeadersWidth = 10;
            this.dgDepenses.RowTemplate.Height = 24;
            this.dgDepenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepenses.Size = new System.Drawing.Size(501, 347);
            this.dgDepenses.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Montant";
            this.dataGridViewTextBoxColumn1.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeService";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypeService";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateDepense";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateDepense";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NomComplet";
            this.dataGridViewTextBoxColumn4.HeaderText = "NomComplet";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // NomCompletE
            // 
            this.NomCompletE.DataPropertyName = "NomCompletE";
            this.NomCompletE.HeaderText = "NomCompletE";
            this.NomCompletE.MinimumWidth = 6;
            this.NomCompletE.Name = "NomCompletE";
            this.NomCompletE.ReadOnly = true;
            this.NomCompletE.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idEmploye";
            this.dataGridViewTextBoxColumn6.HeaderText = "idEmploye";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn7.HeaderText = "No";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "Rapport";
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.Rapport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private BDB56Projet2GSDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private BDB56Projet2GSDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgEmployes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomComplet;
        private System.Windows.Forms.DataGridView dgDepenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCompletE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}