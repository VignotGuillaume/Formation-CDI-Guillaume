namespace PageStart
{
    partial class ConteneurMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem1,
            this.gestionDesSalariésToolStripMenuItem});
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion";
            // 
            // gestionDesUtilisateursToolStripMenuItem1
            // 
            this.gestionDesUtilisateursToolStripMenuItem1.Name = "gestionDesUtilisateursToolStripMenuItem1";
            this.gestionDesUtilisateursToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.gestionDesUtilisateursToolStripMenuItem1.Text = "Gestion des Utilisateurs";
            this.gestionDesUtilisateursToolStripMenuItem1.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem1_Click);
            // 
            // gestionDesSalariésToolStripMenuItem
            // 
            this.gestionDesSalariésToolStripMenuItem.Name = "gestionDesSalariésToolStripMenuItem";
            this.gestionDesSalariésToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.gestionDesSalariésToolStripMenuItem.Text = "Gestion des salariés";
            // 
            // ConteneurMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 346);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConteneurMDI";
            this.Text = "Conteneur MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesSalariésToolStripMenuItem;
    }
}

