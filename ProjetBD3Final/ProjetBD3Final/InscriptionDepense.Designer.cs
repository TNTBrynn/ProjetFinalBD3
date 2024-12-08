namespace ProjetBD3Final
{
    partial class InscriptionDepense
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
            this.abonnementsDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsDTTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.AbonnementsDTTableAdapter();
            this.dgAbonnes = new System.Windows.Forms.DataGridView();
            this.numMontant = new System.Windows.Forms.NumericUpDown();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.RichTextBox();
            this.btnAjoutDepense = new System.Windows.Forms.Button();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.ServicesTableAdapter();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
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
            this.tableAdapterManager.ProvincesTableAdapter = null;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // abonnementsDTBindingSource
            // 
            this.abonnementsDTBindingSource.DataMember = "AbonnementsDT";
            this.abonnementsDTBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // abonnementsDTTableAdapter
            // 
            this.abonnementsDTTableAdapter.ClearBeforeFill = true;
            // 
            // dgAbonnes
            // 
            this.dgAbonnes.AllowUserToAddRows = false;
            this.dgAbonnes.AllowUserToDeleteRows = false;
            this.dgAbonnes.AutoGenerateColumns = false;
            this.dgAbonnes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn2});
            this.dgAbonnes.DataSource = this.abonnementsDTBindingSource;
            this.dgAbonnes.Location = new System.Drawing.Point(12, 12);
            this.dgAbonnes.Name = "dgAbonnes";
            this.dgAbonnes.ReadOnly = true;
            this.dgAbonnes.RowHeadersWidth = 10;
            this.dgAbonnes.RowTemplate.Height = 24;
            this.dgAbonnes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnes.Size = new System.Drawing.Size(360, 439);
            this.dgAbonnes.TabIndex = 0;
            // 
            // numMontant
            // 
            this.numMontant.Location = new System.Drawing.Point(555, 48);
            this.numMontant.Name = "numMontant";
            this.numMontant.Size = new System.Drawing.Size(120, 22);
            this.numMontant.TabIndex = 2;
            this.numMontant.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(390, 50);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(150, 16);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant de la dépense :";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Location = new System.Drawing.Point(390, 108);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(143, 16);
            this.lblRemarque.TabIndex = 4;
            this.lblRemarque.Text = "Remarque (optionnel) :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(393, 139);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(382, 81);
            this.tbRemarque.TabIndex = 5;
            this.tbRemarque.Text = "";
            // 
            // btnAjoutDepense
            // 
            this.btnAjoutDepense.Location = new System.Drawing.Point(452, 347);
            this.btnAjoutDepense.Name = "btnAjoutDepense";
            this.btnAjoutDepense.Size = new System.Drawing.Size(276, 50);
            this.btnAjoutDepense.TabIndex = 6;
            this.btnAjoutDepense.Text = "Ajouter la dépense";
            this.btnAjoutDepense.UseVisualStyleBackColor = true;
            this.btnAjoutDepense.Click += new System.EventHandler(this.btnAjoutDepense_Click);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource1
            // 
            this.servicesBindingSource1.DataMember = "Services";
            this.servicesBindingSource1.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type de service:";
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(479, 276);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(209, 24);
            this.cbService.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomComplet";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomComplet";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // InscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 471);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjoutDepense);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.numMontant);
            this.Controls.Add(this.dgAbonnes);
            this.Name = "InscriptionDepense";
            this.Text = "InscriptionDepense";
            this.Load += new System.EventHandler(this.InscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet2GSDataSet bDB56Projet2GSDataSet;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private BDB56Projet2GSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource abonnementsDTBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.AbonnementsDTTableAdapter abonnementsDTTableAdapter;
        private System.Windows.Forms.DataGridView dgAbonnes;
        private System.Windows.Forms.NumericUpDown numMontant;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.RichTextBox tbRemarque;
        private System.Windows.Forms.Button btnAjoutDepense;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}