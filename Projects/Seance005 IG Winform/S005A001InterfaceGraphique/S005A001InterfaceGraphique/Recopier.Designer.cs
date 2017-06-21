namespace S005A001InterfaceGraphique
{
    partial class Recopier
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
            this.texteARecopier = new System.Windows.Forms.TextBox();
            this.btnRecopier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelCopie = new System.Windows.Forms.Label();
            this.texteCopie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texteARecopier
            // 
            this.texteARecopier.Location = new System.Drawing.Point(135, 35);
            this.texteARecopier.Name = "texteARecopier";
            this.texteARecopier.Size = new System.Drawing.Size(422, 20);
            this.texteARecopier.TabIndex = 0;
            this.texteARecopier.Text = "Entrer le texte initial";
            // 
            // btnRecopier
            // 
            this.btnRecopier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecopier.Location = new System.Drawing.Point(652, 121);
            this.btnRecopier.Name = "btnRecopier";
            this.btnRecopier.Size = new System.Drawing.Size(75, 23);
            this.btnRecopier.TabIndex = 1;
            this.btnRecopier.Text = "Recopier";
            this.btnRecopier.UseVisualStyleBackColor = true;
            this.btnRecopier.Click += new System.EventHandler(this.btnRecopier_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(652, 162);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 2;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(652, 202);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(52, 35);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(42, 13);
            this.labelOriginal.TabIndex = 4;
            this.labelOriginal.Text = "Original";
            // 
            // labelCopie
            // 
            this.labelCopie.AutoSize = true;
            this.labelCopie.Location = new System.Drawing.Point(52, 162);
            this.labelCopie.Name = "labelCopie";
            this.labelCopie.Size = new System.Drawing.Size(34, 13);
            this.labelCopie.TabIndex = 5;
            this.labelCopie.Text = "Copie";
            // 
            // texteCopie
            // 
            this.texteCopie.AutoSize = true;
            this.texteCopie.Location = new System.Drawing.Point(135, 162);
            this.texteCopie.Name = "texteCopie";
            this.texteCopie.Size = new System.Drawing.Size(0, 13);
            this.texteCopie.TabIndex = 6;
            // 
            // Recopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 261);
            this.Controls.Add(this.texteCopie);
            this.Controls.Add(this.labelCopie);
            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnRecopier);
            this.Controls.Add(this.texteARecopier);
            this.Name = "Recopier";
            this.Text = "Recopier un champ dans un autre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texteARecopier;
        private System.Windows.Forms.Button btnRecopier;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelCopie;
        private System.Windows.Forms.Label texteCopie;
    }
}

