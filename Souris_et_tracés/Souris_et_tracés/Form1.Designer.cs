namespace Souris_et_tracés
{
    partial class F_Principal
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
            this.bEllipse = new System.Windows.Forms.Button();
            this.bCouleur_bouton = new System.Windows.Forms.Button();
            this.bTitre = new System.Windows.Forms.Button();
            this.bTempete = new System.Windows.Forms.Button();
            this.bBateau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEllipse
            // 
            this.bEllipse.BackColor = System.Drawing.SystemColors.Highlight;
            this.bEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEllipse.Location = new System.Drawing.Point(850, 35);
            this.bEllipse.Name = "bEllipse";
            this.bEllipse.Size = new System.Drawing.Size(114, 54);
            this.bEllipse.TabIndex = 0;
            this.bEllipse.Text = "Ellipse";
            this.bEllipse.UseVisualStyleBackColor = false;
            this.bEllipse.Click += new System.EventHandler(this.bEllipse_Click);
            // 
            // bCouleur_bouton
            // 
            this.bCouleur_bouton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bCouleur_bouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCouleur_bouton.Location = new System.Drawing.Point(850, 211);
            this.bCouleur_bouton.Name = "bCouleur_bouton";
            this.bCouleur_bouton.Size = new System.Drawing.Size(114, 59);
            this.bCouleur_bouton.TabIndex = 1;
            this.bCouleur_bouton.Text = "Couleur";
            this.bCouleur_bouton.UseVisualStyleBackColor = false;
            this.bCouleur_bouton.Click += new System.EventHandler(this.bCouleur_bouton_Click);
            // 
            // bTitre
            // 
            this.bTitre.BackColor = System.Drawing.Color.Red;
            this.bTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTitre.Location = new System.Drawing.Point(850, 119);
            this.bTitre.Name = "bTitre";
            this.bTitre.Size = new System.Drawing.Size(114, 57);
            this.bTitre.TabIndex = 2;
            this.bTitre.Text = "Titre";
            this.bTitre.UseVisualStyleBackColor = false;
            this.bTitre.Click += new System.EventHandler(this.bTitre_Click);
            // 
            // bTempete
            // 
            this.bTempete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bTempete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTempete.Location = new System.Drawing.Point(850, 301);
            this.bTempete.Name = "bTempete";
            this.bTempete.Size = new System.Drawing.Size(114, 54);
            this.bTempete.TabIndex = 3;
            this.bTempete.Text = "Message";
            this.bTempete.UseVisualStyleBackColor = false;
            this.bTempete.Click += new System.EventHandler(this.bTempete_Click);
            // 
            // bBateau
            // 
            this.bBateau.BackgroundImage = global::Souris_et_tracés.Properties.Resources.petitbateau_orig;
            this.bBateau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bBateau.Location = new System.Drawing.Point(600, 20);
            this.bBateau.Name = "bBateau";
            this.bBateau.Size = new System.Drawing.Size(123, 87);
            this.bBateau.TabIndex = 4;
            this.bBateau.UseVisualStyleBackColor = true;
            this.bBateau.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Souris_et_tracés.Properties.Resources.guyane;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 602);
            this.Controls.Add(this.bBateau);
            this.Controls.Add(this.bTempete);
            this.Controls.Add(this.bTitre);
            this.Controls.Add(this.bCouleur_bouton);
            this.Controls.Add(this.bEllipse);
            this.Name = "F_Principal";
            this.Text = "Bonjour";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.F_Principal_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_Principal_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEllipse;
        private System.Windows.Forms.Button bCouleur_bouton;
        private System.Windows.Forms.Button bTitre;
        private System.Windows.Forms.Button bTempete;
        private System.Windows.Forms.Button bBateau;
    }
}

