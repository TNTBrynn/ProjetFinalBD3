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
            this.abonnementsDTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAjoutDepense = new System.Windows.Forms.Button();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.ServicesTableAdapter();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            // abonnementsDTDataGridView
            // 
            this.abonnementsDTDataGridView.AllowUserToAddRows = false;
            this.abonnementsDTDataGridView.AllowUserToDeleteRows = false;
            this.abonnementsDTDataGridView.AutoGenerateColumns = false;
            this.abonnementsDTDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.abonnementsDTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonnementsDTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.abonnementsDTDataGridView.DataSource = this.abonnementsDTBindingSource;
            this.abonnementsDTDataGridView.Location = new System.Drawing.Point(12, 12);
            this.abonnementsDTDataGridView.Name = "abonnementsDTDataGridView";
            this.abonnementsDTDataGridView.ReadOnly = true;
            this.abonnementsDTDataGridView.RowHeadersWidth = 10;
            this.abonnementsDTDataGridView.RowTemplate.Height = 24;
            this.abonnementsDTDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonnementsDTDataGridView.Size = new System.Drawing.Size(360, 439);
            this.abonnementsDTDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomComplet";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomComplet";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(555, 48);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
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
            this.lblRemarque.Location = new System.Drawing.Point(390, 101);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(143, 16);
            this.lblRemarque.TabIndex = 4;
            this.lblRemarque.Text = "Remarque (optionnel) :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(393, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 81);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnAjoutDepense
            // 
            this.btnAjoutDepense.Location = new System.Drawing.Point(452, 347);
            this.btnAjoutDepense.Name = "btnAjoutDepense";
            this.btnAjoutDepense.Size = new System.Drawing.Size(276, 50);
            this.btnAjoutDepense.TabIndex = 6;
            this.btnAjoutDepense.Text = "Ajouter la dépense";
            this.btnAjoutDepense.UseVisualStyleBackColor = true;
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
            // servicesComboBox
            // 
            this.servicesComboBox.DataSource = this.servicesBindingSource1;
            this.servicesComboBox.DisplayMember = "TypeService";
            this.servicesComboBox.FormattingEnabled = true;
            this.servicesComboBox.Location = new System.Drawing.Point(440, 276);
            this.servicesComboBox.Name = "servicesComboBox";
            this.servicesComboBox.Size = new System.Drawing.Size(300, 24);
            this.servicesComboBox.TabIndex = 6;
            this.servicesComboBox.ValueMember = "No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type de service:";
            // 
            // InscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicesComboBox);
            this.Controls.Add(this.btnAjoutDepense);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.abonnementsDTDataGridView);
            this.Name = "InscriptionDepense";
            this.Text = "InscriptionDepense";
            this.Load += new System.EventHandler(this.InscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.DataGridView abonnementsDTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAjoutDepense;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private System.Windows.Forms.ComboBox servicesComboBox;
        private System.Windows.Forms.Label label1;
    }
}