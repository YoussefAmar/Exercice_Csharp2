namespace Premier_pas
{
    partial class FP
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
            this.bSpeedy = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.Label();
            this.lPasswd = new System.Windows.Forms.Label();
            this.tBPasswd = new System.Windows.Forms.TextBox();
            this.tBUser = new System.Windows.Forms.TextBox();
            this.bAffiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSpeedy
            // 
            this.bSpeedy.Location = new System.Drawing.Point(90, 334);
            this.bSpeedy.Name = "bSpeedy";
            this.bSpeedy.Size = new System.Drawing.Size(118, 66);
            this.bSpeedy.TabIndex = 0;
            this.bSpeedy.Text = "Arriba";
            this.bSpeedy.UseVisualStyleBackColor = true;
            this.bSpeedy.Click += new System.EventHandler(this.bSpeedy_Click);
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(104, 211);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(80, 20);
            this.lUser.TabIndex = 1;
            this.lUser.Text = "Utilisateur";
            // 
            // lPasswd
            // 
            this.lPasswd.AutoSize = true;
            this.lPasswd.Location = new System.Drawing.Point(104, 268);
            this.lPasswd.Name = "lPasswd";
            this.lPasswd.Size = new System.Drawing.Size(105, 20);
            this.lPasswd.TabIndex = 2;
            this.lPasswd.Text = "Mot de passe";
            // 
            // tBPasswd
            // 
            this.tBPasswd.Location = new System.Drawing.Point(395, 268);
            this.tBPasswd.Name = "tBPasswd";
            this.tBPasswd.PasswordChar = '*';
            this.tBPasswd.Size = new System.Drawing.Size(164, 26);
            this.tBPasswd.TabIndex = 3;
            this.tBPasswd.Enter += new System.EventHandler(this.tBPasswd_Enter);
            // 
            // tBUser
            // 
            this.tBUser.Location = new System.Drawing.Point(395, 211);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(164, 26);
            this.tBUser.TabIndex = 4;
            this.tBUser.Enter += new System.EventHandler(this.tBUser_Enter);
            // 
            // bAffiche
            // 
            this.bAffiche.Location = new System.Drawing.Point(395, 334);
            this.bAffiche.Name = "bAffiche";
            this.bAffiche.Size = new System.Drawing.Size(121, 66);
            this.bAffiche.TabIndex = 5;
            this.bAffiche.Text = "Affiche";
            this.bAffiche.UseVisualStyleBackColor = true;
            this.bAffiche.Click += new System.EventHandler(this.bAffiche_Click);
            // 
            // FP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAffiche);
            this.Controls.Add(this.tBUser);
            this.Controls.Add(this.tBPasswd);
            this.Controls.Add(this.lPasswd);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.bSpeedy);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FP";
            this.Opacity = 0.8D;
            this.Text = "FPrincipal";
            this.Load += new System.EventHandler(this.FP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSpeedy;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lPasswd;
        private System.Windows.Forms.TextBox tBPasswd;
        private System.Windows.Forms.TextBox tBUser;
        private System.Windows.Forms.Button bAffiche;
    }
}

