namespace ProjetBD3Final
{
    partial class Reabonnement
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
            this.dgAbonnement = new System.Windows.Forms.DataGridView();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenouveller = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).BeginInit();
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
            this.dgAbonnement.TabIndex = 0;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(215, 179);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(100, 20);
            this.tbRemarque.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remarque:";
            // 
            // btnRenouveller
            // 
            this.btnRenouveller.Location = new System.Drawing.Point(12, 179);
            this.btnRenouveller.Name = "btnRenouveller";
            this.btnRenouveller.Size = new System.Drawing.Size(128, 38);
            this.btnRenouveller.TabIndex = 3;
            this.btnRenouveller.Text = "Renouveller l\'abonnement";
            this.btnRenouveller.UseVisualStyleBackColor = true;
            this.btnRenouveller.Click += new System.EventHandler(this.btnRenouveller_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(364, 194);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Reabonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 229);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnRenouveller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.dgAbonnement);
            this.Name = "Reabonnement";
            this.Text = "Réabonnement";
            this.Load += new System.EventHandler(this.Reabonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAbonnement;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRenouveller;
        private System.Windows.Forms.Button btnAnnuler;
    }
}