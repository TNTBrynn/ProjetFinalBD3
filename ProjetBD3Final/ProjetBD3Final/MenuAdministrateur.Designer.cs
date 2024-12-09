namespace ProjetBD3Final
{
    partial class MenuAdministrateur
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAbonnement = new System.Windows.Forms.Button();
            this.btnReabonnement = new System.Windows.Forms.Button();
            this.btnMajAbonne = new System.Windows.Forms.Button();
            this.btnInscriptionPartie = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestion des employés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 51);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gestion des prix";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 51);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAbonnement
            // 
            this.btnAbonnement.Location = new System.Drawing.Point(34, 149);
            this.btnAbonnement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbonnement.Name = "btnAbonnement";
            this.btnAbonnement.Size = new System.Drawing.Size(128, 37);
            this.btnAbonnement.TabIndex = 4;
            this.btnAbonnement.Text = "Abonnement";
            this.btnAbonnement.UseVisualStyleBackColor = true;
            this.btnAbonnement.Click += new System.EventHandler(this.btnAbonnement_Click);
            // 
            // btnReabonnement
            // 
            this.btnReabonnement.Location = new System.Drawing.Point(226, 149);
            this.btnReabonnement.Margin = new System.Windows.Forms.Padding(2);
            this.btnReabonnement.Name = "btnReabonnement";
            this.btnReabonnement.Size = new System.Drawing.Size(128, 37);
            this.btnReabonnement.TabIndex = 5;
            this.btnReabonnement.Text = "Réabonnement";
            this.btnReabonnement.UseVisualStyleBackColor = true;
            this.btnReabonnement.Click += new System.EventHandler(this.btnReabonnement_Click);
            // 
            // btnMajAbonne
            // 
            this.btnMajAbonne.Location = new System.Drawing.Point(427, 149);
            this.btnMajAbonne.Margin = new System.Windows.Forms.Padding(2);
            this.btnMajAbonne.Name = "btnMajAbonne";
            this.btnMajAbonne.Size = new System.Drawing.Size(128, 37);
            this.btnMajAbonne.TabIndex = 6;
            this.btnMajAbonne.Text = "Mise à jour abonnés";
            this.btnMajAbonne.UseVisualStyleBackColor = true;
            this.btnMajAbonne.Click += new System.EventHandler(this.btnMajAbonne_Click);
            // 
            // btnInscriptionPartie
            // 
            this.btnInscriptionPartie.Location = new System.Drawing.Point(34, 247);
            this.btnInscriptionPartie.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscriptionPartie.Name = "btnInscriptionPartie";
            this.btnInscriptionPartie.Size = new System.Drawing.Size(162, 37);
            this.btnInscriptionPartie.TabIndex = 7;
            this.btnInscriptionPartie.Text = "Inscription d\'une partie jouée";
            this.btnInscriptionPartie.UseVisualStyleBackColor = true;
            this.btnInscriptionPartie.Click += new System.EventHandler(this.btnInscriptionPartie_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Location = new System.Drawing.Point(226, 247);
            this.btnStatistiques.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(128, 37);
            this.btnStatistiques.TabIndex = 8;
            this.btnStatistiques.Text = "Statistiques";
            this.btnStatistiques.UseVisualStyleBackColor = true;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // MenuAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnStatistiques);
            this.Controls.Add(this.btnInscriptionPartie);
            this.Controls.Add(this.btnMajAbonne);
            this.Controls.Add(this.btnReabonnement);
            this.Controls.Add(this.btnAbonnement);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuAdministrateur";
            this.Text = "MenuAdministrateur";
            this.Load += new System.EventHandler(this.MenuAdministrateur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAbonnement;
        private System.Windows.Forms.Button btnReabonnement;
        private System.Windows.Forms.Button btnMajAbonne;
        private System.Windows.Forms.Button btnInscriptionPartie;
        private System.Windows.Forms.Button btnStatistiques;
    }
}