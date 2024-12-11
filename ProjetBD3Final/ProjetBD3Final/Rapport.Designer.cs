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
            System.Windows.Forms.Label dateDepenseLabel;
            System.Windows.Forms.Label dateDepenseLabel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgDepenses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCompletE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet2GSDataSet = new ProjetBD3Final.BDB56Projet2GSDataSet();
            this.dgEmployes = new System.Windows.Forms.DataGridView();
            this.NomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataTable1TableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.TableAdapterManager();
            this.dataTable2TableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.DataTable2TableAdapter();
            this.dgAbonnements = new System.Windows.Forms.DataGridView();
            this.dgDepenses2 = new System.Windows.Forms.DataGridView();
            this.dgDepenses3 = new System.Windows.Forms.DataGridView();
            this.depensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depensesTableAdapter = new ProjetBD3Final.BDB56Projet2GSDataSetTableAdapters.DepensesTableAdapter();
            this.cbAnnee = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgTerrains = new System.Windows.Forms.DataGridView();
            this.dgParties = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgAbonnement2 = new System.Windows.Forms.DataGridView();
            this.dgParties2 = new System.Windows.Forms.DataGridView();
            this.dgParties3 = new System.Windows.Forms.DataGridView();
            this.cbAnnee2 = new System.Windows.Forms.ComboBox();
            dateDepenseLabel = new System.Windows.Forms.Label();
            dateDepenseLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTerrains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParties)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParties2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParties3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
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
            this.NomCompletE});
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgDepenses2);
            this.tabPage2.Controls.Add(this.dgAbonnements);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "dépenses par abonnement";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.cbAnnee);
            this.tabPage3.Controls.Add(dateDepenseLabel);
            this.tabPage3.Controls.Add(this.dgDepenses3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(839, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "dépenses par année";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // dgAbonnements
            // 
            this.dgAbonnements.AllowUserToAddRows = false;
            this.dgAbonnements.AllowUserToDeleteRows = false;
            this.dgAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnements.Location = new System.Drawing.Point(36, 38);
            this.dgAbonnements.MultiSelect = false;
            this.dgAbonnements.Name = "dgAbonnements";
            this.dgAbonnements.ReadOnly = true;
            this.dgAbonnements.RowHeadersWidth = 10;
            this.dgAbonnements.RowTemplate.Height = 24;
            this.dgAbonnements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnements.Size = new System.Drawing.Size(333, 315);
            this.dgAbonnements.TabIndex = 0;
            this.dgAbonnements.SelectionChanged += new System.EventHandler(this.dgAbonnements_SelectionChanged);
            // 
            // dgDepenses2
            // 
            this.dgDepenses2.AllowUserToAddRows = false;
            this.dgDepenses2.AllowUserToDeleteRows = false;
            this.dgDepenses2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepenses2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepenses2.Location = new System.Drawing.Point(408, 38);
            this.dgDepenses2.MultiSelect = false;
            this.dgDepenses2.Name = "dgDepenses2";
            this.dgDepenses2.ReadOnly = true;
            this.dgDepenses2.RowHeadersWidth = 10;
            this.dgDepenses2.RowTemplate.Height = 24;
            this.dgDepenses2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepenses2.Size = new System.Drawing.Size(383, 315);
            this.dgDepenses2.TabIndex = 1;
            // 
            // dgDepenses3
            // 
            this.dgDepenses3.AllowUserToAddRows = false;
            this.dgDepenses3.AllowUserToDeleteRows = false;
            this.dgDepenses3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepenses3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepenses3.Location = new System.Drawing.Point(249, 31);
            this.dgDepenses3.MultiSelect = false;
            this.dgDepenses3.Name = "dgDepenses3";
            this.dgDepenses3.ReadOnly = true;
            this.dgDepenses3.RowHeadersWidth = 10;
            this.dgDepenses3.RowTemplate.Height = 24;
            this.dgDepenses3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepenses3.Size = new System.Drawing.Size(573, 345);
            this.dgDepenses3.TabIndex = 1;
            // 
            // depensesBindingSource
            // 
            this.depensesBindingSource.DataMember = "Depenses";
            this.depensesBindingSource.DataSource = this.bDB56Projet2GSDataSet;
            // 
            // depensesTableAdapter
            // 
            this.depensesTableAdapter.ClearBeforeFill = true;
            // 
            // dateDepenseLabel
            // 
            dateDepenseLabel.AutoSize = true;
            dateDepenseLabel.Location = new System.Drawing.Point(59, 137);
            dateDepenseLabel.Name = "dateDepenseLabel";
            dateDepenseLabel.Size = new System.Drawing.Size(98, 16);
            dateDepenseLabel.TabIndex = 2;
            dateDepenseLabel.Text = "Date Depense:";
            // 
            // cbAnnee
            // 
            this.cbAnnee.FormattingEnabled = true;
            this.cbAnnee.Location = new System.Drawing.Point(50, 180);
            this.cbAnnee.Name = "cbAnnee";
            this.cbAnnee.Size = new System.Drawing.Size(121, 24);
            this.cbAnnee.TabIndex = 3;
            this.cbAnnee.SelectedIndexChanged += new System.EventHandler(this.cbAnnee_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgParties);
            this.tabPage4.Controls.Add(this.dgTerrains);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(839, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "parties par terrain";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dgTerrains
            // 
            this.dgTerrains.AllowUserToAddRows = false;
            this.dgTerrains.AllowUserToDeleteRows = false;
            this.dgTerrains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTerrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTerrains.Location = new System.Drawing.Point(26, 34);
            this.dgTerrains.MultiSelect = false;
            this.dgTerrains.Name = "dgTerrains";
            this.dgTerrains.ReadOnly = true;
            this.dgTerrains.RowHeadersWidth = 10;
            this.dgTerrains.RowTemplate.Height = 24;
            this.dgTerrains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTerrains.Size = new System.Drawing.Size(257, 331);
            this.dgTerrains.TabIndex = 0;
            this.dgTerrains.SelectionChanged += new System.EventHandler(this.dgTerrains_SelectionChanged);
            // 
            // dgParties
            // 
            this.dgParties.AllowUserToAddRows = false;
            this.dgParties.AllowUserToDeleteRows = false;
            this.dgParties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgParties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParties.Location = new System.Drawing.Point(343, 34);
            this.dgParties.MultiSelect = false;
            this.dgParties.Name = "dgParties";
            this.dgParties.ReadOnly = true;
            this.dgParties.RowHeadersWidth = 10;
            this.dgParties.RowTemplate.Height = 24;
            this.dgParties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParties.Size = new System.Drawing.Size(469, 331);
            this.dgParties.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgParties2);
            this.tabPage5.Controls.Add(this.dgAbonnement2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(839, 405);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "parties jouées par abonnement";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Controls.Add(dateDepenseLabel1);
            this.tabPage6.Controls.Add(this.cbAnnee2);
            this.tabPage6.Controls.Add(this.dgParties3);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(839, 405);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "parties jouées par année";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgAbonnement2
            // 
            this.dgAbonnement2.AllowUserToAddRows = false;
            this.dgAbonnement2.AllowUserToDeleteRows = false;
            this.dgAbonnement2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnement2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnement2.Location = new System.Drawing.Point(6, 6);
            this.dgAbonnement2.MultiSelect = false;
            this.dgAbonnement2.Name = "dgAbonnement2";
            this.dgAbonnement2.ReadOnly = true;
            this.dgAbonnement2.RowHeadersWidth = 10;
            this.dgAbonnement2.RowTemplate.Height = 24;
            this.dgAbonnement2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnement2.Size = new System.Drawing.Size(361, 393);
            this.dgAbonnement2.TabIndex = 0;
            this.dgAbonnement2.SelectionChanged += new System.EventHandler(this.dgAbonnement2_SelectionChanged);
            // 
            // dgParties2
            // 
            this.dgParties2.AllowUserToAddRows = false;
            this.dgParties2.AllowUserToDeleteRows = false;
            this.dgParties2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgParties2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParties2.Location = new System.Drawing.Point(457, 6);
            this.dgParties2.MultiSelect = false;
            this.dgParties2.Name = "dgParties2";
            this.dgParties2.ReadOnly = true;
            this.dgParties2.RowHeadersWidth = 10;
            this.dgParties2.RowTemplate.Height = 24;
            this.dgParties2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParties2.Size = new System.Drawing.Size(376, 393);
            this.dgParties2.TabIndex = 1;
            // 
            // dgParties3
            // 
            this.dgParties3.AllowUserToAddRows = false;
            this.dgParties3.AllowUserToDeleteRows = false;
            this.dgParties3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgParties3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParties3.Location = new System.Drawing.Point(291, 6);
            this.dgParties3.MultiSelect = false;
            this.dgParties3.Name = "dgParties3";
            this.dgParties3.ReadOnly = true;
            this.dgParties3.RowHeadersWidth = 10;
            this.dgParties3.RowTemplate.Height = 24;
            this.dgParties3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParties3.Size = new System.Drawing.Size(532, 393);
            this.dgParties3.TabIndex = 0;
            // 
            // cbAnnee2
            // 
            this.cbAnnee2.FormattingEnabled = true;
            this.cbAnnee2.Location = new System.Drawing.Point(58, 177);
            this.cbAnnee2.Name = "cbAnnee2";
            this.cbAnnee2.Size = new System.Drawing.Size(121, 24);
            this.cbAnnee2.TabIndex = 1;
            this.cbAnnee2.SelectedIndexChanged += new System.EventHandler(this.cbAnnee2_SelectedIndexChanged);
            // 
            // dateDepenseLabel1
            // 
            dateDepenseLabel1.AutoSize = true;
            dateDepenseLabel1.Location = new System.Drawing.Point(69, 142);
            dateDepenseLabel1.Name = "dateDepenseLabel1";
            dateDepenseLabel1.Size = new System.Drawing.Size(98, 16);
            dateDepenseLabel1.TabIndex = 2;
            dateDepenseLabel1.Text = "Date Depense:";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet2GSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenses3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTerrains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParties)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParties2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParties3)).EndInit();
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
        private System.Windows.Forms.DataGridView dgAbonnements;
        private System.Windows.Forms.DataGridView dgDepenses2;
        private System.Windows.Forms.DataGridView dgDepenses3;
        private System.Windows.Forms.BindingSource depensesBindingSource;
        private BDB56Projet2GSDataSetTableAdapters.DepensesTableAdapter depensesTableAdapter;
        private System.Windows.Forms.ComboBox cbAnnee;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgParties;
        private System.Windows.Forms.DataGridView dgTerrains;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgParties2;
        private System.Windows.Forms.DataGridView dgAbonnement2;
        private System.Windows.Forms.ComboBox cbAnnee2;
        private System.Windows.Forms.DataGridView dgParties3;
    }
}