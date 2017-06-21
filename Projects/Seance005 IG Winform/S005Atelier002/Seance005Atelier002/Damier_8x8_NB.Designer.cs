namespace Seance005Atelier002
{
    partial class Damier_8x8_NB
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
            this.panelDamier = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelDamier
            // 
            this.panelDamier.AutoSize = true;
            this.panelDamier.Location = new System.Drawing.Point(12, 12);
            this.panelDamier.Name = "panelDamier";
            this.panelDamier.Size = new System.Drawing.Size(580, 564);
            this.panelDamier.TabIndex = 0;
            // 
            // Damier_8x8_NB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(604, 669);
            this.Controls.Add(this.panelDamier);
            this.Name = "Damier_8x8_NB";
            this.Text = "Damier 8*8  N&B";
            this.Load += new System.EventHandler(this.Damier_8x8_NB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDamier;
    }
}

