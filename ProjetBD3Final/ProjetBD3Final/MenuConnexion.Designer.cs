namespace ProjetBD3Final
{
    partial class MenuConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomUtilisateur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(255, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(14, 123);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(181, 27);
            this.btnConnexion.TabIndex = 10;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe:";
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMDP.Location = new System.Drawing.Point(255, 65);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(160, 26);
            this.tbMDP.TabIndex = 8;
            this.tbMDP.Text = "Password1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom d\'utilisateur:";
            // 
            // tbNomUtilisateur
            // 
            this.tbNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomUtilisateur.Location = new System.Drawing.Point(255, 14);
            this.tbNomUtilisateur.Name = "tbNomUtilisateur";
            this.tbNomUtilisateur.Size = new System.Drawing.Size(160, 26);
            this.tbNomUtilisateur.TabIndex = 6;
            this.tbNomUtilisateur.Text = "adminAbdou";
            // 
            // MenuConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 187);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomUtilisateur);
            this.Name = "MenuConnexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomUtilisateur;
    }
}

