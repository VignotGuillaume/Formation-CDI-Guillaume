namespace Damier_10x10_RJ
{
    partial class Damier10x10RJ
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
            this.PanelRJ = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelRJ
            // 
            this.PanelRJ.Location = new System.Drawing.Point(0, 0);
            this.PanelRJ.Name = "PanelRJ";
            this.PanelRJ.Size = new System.Drawing.Size(1052, 683);
            this.PanelRJ.TabIndex = 0;
            // 
            // Damier10x10RJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1074, 695);
            this.Controls.Add(this.PanelRJ);
            this.Name = "Damier10x10RJ";
            this.Text = "Damier10x10RJ";
            this.Load += new System.EventHandler(this.Damier10x10RJ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRJ;
    }
}

