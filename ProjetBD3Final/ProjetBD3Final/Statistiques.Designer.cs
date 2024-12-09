namespace ProjetBD3Final
{
    partial class Statistiques
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Abonnement = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgAbonnementAnneeCourante = new System.Windows.Forms.DataGridView();
            this.dgAbonnementParAnnee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSousTotalAbonnement = new System.Windows.Forms.TextBox();
            this.tbTotalAbonnement = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Abonnement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementAnneeCourante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementParAnnee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Abonnement);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // Abonnement
            // 
            this.Abonnement.Controls.Add(this.tbTotalAbonnement);
            this.Abonnement.Controls.Add(this.tbSousTotalAbonnement);
            this.Abonnement.Controls.Add(this.label2);
            this.Abonnement.Controls.Add(this.label1);
            this.Abonnement.Controls.Add(this.dgAbonnementParAnnee);
            this.Abonnement.Controls.Add(this.dgAbonnementAnneeCourante);
            this.Abonnement.Location = new System.Drawing.Point(4, 22);
            this.Abonnement.Name = "Abonnement";
            this.Abonnement.Padding = new System.Windows.Forms.Padding(3);
            this.Abonnement.Size = new System.Drawing.Size(562, 325);
            this.Abonnement.TabIndex = 0;
            this.Abonnement.Text = "Abonnement";
            this.Abonnement.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(562, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dépenses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgAbonnementAnneeCourante
            // 
            this.dgAbonnementAnneeCourante.AllowUserToAddRows = false;
            this.dgAbonnementAnneeCourante.AllowUserToDeleteRows = false;
            this.dgAbonnementAnneeCourante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnementAnneeCourante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnementAnneeCourante.Location = new System.Drawing.Point(8, 38);
            this.dgAbonnementAnneeCourante.MultiSelect = false;
            this.dgAbonnementAnneeCourante.Name = "dgAbonnementAnneeCourante";
            this.dgAbonnementAnneeCourante.ReadOnly = true;
            this.dgAbonnementAnneeCourante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnementAnneeCourante.Size = new System.Drawing.Size(276, 238);
            this.dgAbonnementAnneeCourante.TabIndex = 0;
            // 
            // dgAbonnementParAnnee
            // 
            this.dgAbonnementParAnnee.AllowUserToAddRows = false;
            this.dgAbonnementParAnnee.AllowUserToDeleteRows = false;
            this.dgAbonnementParAnnee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnementParAnnee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnementParAnnee.Location = new System.Drawing.Point(290, 38);
            this.dgAbonnementParAnnee.MultiSelect = false;
            this.dgAbonnementParAnnee.Name = "dgAbonnementParAnnee";
            this.dgAbonnementParAnnee.ReadOnly = true;
            this.dgAbonnementParAnnee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbonnementParAnnee.Size = new System.Drawing.Size(269, 238);
            this.dgAbonnementParAnnee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abonnement par mois de l\'année courante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abonnement par année";
            // 
            // tbSousTotalAbonnement
            // 
            this.tbSousTotalAbonnement.Location = new System.Drawing.Point(12, 283);
            this.tbSousTotalAbonnement.Name = "tbSousTotalAbonnement";
            this.tbSousTotalAbonnement.ReadOnly = true;
            this.tbSousTotalAbonnement.Size = new System.Drawing.Size(100, 20);
            this.tbSousTotalAbonnement.TabIndex = 4;
            // 
            // tbTotalAbonnement
            // 
            this.tbTotalAbonnement.Location = new System.Drawing.Point(290, 282);
            this.tbTotalAbonnement.Name = "tbTotalAbonnement";
            this.tbTotalAbonnement.ReadOnly = true;
            this.tbTotalAbonnement.Size = new System.Drawing.Size(100, 20);
            this.tbTotalAbonnement.TabIndex = 5;
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 351);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.tabControl1.ResumeLayout(false);
            this.Abonnement.ResumeLayout(false);
            this.Abonnement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementAnneeCourante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementParAnnee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Abonnement;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgAbonnementAnneeCourante;
        private System.Windows.Forms.DataGridView dgAbonnementParAnnee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotalAbonnement;
        private System.Windows.Forms.TextBox tbSousTotalAbonnement;
    }
}