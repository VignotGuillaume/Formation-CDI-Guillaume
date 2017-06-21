namespace ex2_jouer_avec_les_caractere_d_une_chaine_de_caractere_
{
    partial class categorieDuCaractere
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
            this.textBoxSaisir = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxResultat = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.labelSaisir = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSaisir
            // 
            this.textBoxSaisir.Location = new System.Drawing.Point(219, 34);
            this.textBoxSaisir.Name = "textBoxSaisir";
            this.textBoxSaisir.Size = new System.Drawing.Size(409, 20);
            this.textBoxSaisir.TabIndex = 0;
            this.textBoxSaisir.Text = "Saisissez ici une chaine de caractere";
            this.textBoxSaisir.TextChanged += new System.EventHandler(this.textBoxSaisir_TextChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown.Enabled = false;
            this.numericUpDown.Location = new System.Drawing.Point(219, 148);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(164, 20);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // textBoxResultat
            // 
            this.textBoxResultat.Enabled = false;
            this.textBoxResultat.Location = new System.Drawing.Point(219, 266);
            this.textBoxResultat.Name = "textBoxResultat";
            this.textBoxResultat.ReadOnly = true;
            this.textBoxResultat.Size = new System.Drawing.Size(398, 20);
            this.textBoxResultat.TabIndex = 2;
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.Enabled = false;
            this.button.Location = new System.Drawing.Point(41, 366);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(229, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Catégorie du caractère";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelSaisir
            // 
            this.labelSaisir.AutoSize = true;
            this.labelSaisir.Location = new System.Drawing.Point(38, 41);
            this.labelSaisir.Name = "labelSaisir";
            this.labelSaisir.Size = new System.Drawing.Size(112, 13);
            this.labelSaisir.TabIndex = 4;
            this.labelSaisir.Text = "Saisissez une chaine :";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(38, 150);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(107, 13);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Position du caractère";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(38, 273);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Résultat";
            // 
            // categorieDuCaractere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 422);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelSaisir);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxResultat);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBoxSaisir);
            this.Name = "categorieDuCaractere";
            this.Text = "Catégorie du caractère";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSaisir;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox textBoxResultat;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelSaisir;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label label;
    }
}

