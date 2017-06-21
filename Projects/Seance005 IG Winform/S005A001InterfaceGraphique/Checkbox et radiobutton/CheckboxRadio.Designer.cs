namespace Checkbox_et_radiobutton
{
    partial class CheckboxRadio
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
            this.TaperVotreTexte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.casse = new System.Windows.Forms.CheckBox();
            this.couleurDesCaracteres = new System.Windows.Forms.CheckBox();
            this.couleurDuFond = new System.Windows.Forms.CheckBox();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.radioButtonFondBleu = new System.Windows.Forms.RadioButton();
            this.radioButtonFondVert = new System.Windows.Forms.RadioButton();
            this.radioButtonFondRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCaractere = new System.Windows.Forms.GroupBox();
            this.radioButtonCaracNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonCaracBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonCaracRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButtonCasseMin = new System.Windows.Forms.RadioButton();
            this.radioButtonCasseMaj = new System.Windows.Forms.RadioButton();
            this.resultat = new System.Windows.Forms.Label();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxFond.SuspendLayout();
            this.groupBoxCaractere.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaperVotreTexte
            // 
            this.TaperVotreTexte.AutoSize = true;
            this.TaperVotreTexte.Location = new System.Drawing.Point(12, 9);
            this.TaperVotreTexte.Name = "TaperVotreTexte";
            this.TaperVotreTexte.Size = new System.Drawing.Size(90, 13);
            this.TaperVotreTexte.TabIndex = 1;
            this.TaperVotreTexte.Text = "Tapez votre texte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Salut tout le monde";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.casse);
            this.groupBoxChoix.Controls.Add(this.couleurDesCaracteres);
            this.groupBoxChoix.Controls.Add(this.couleurDuFond);
            this.groupBoxChoix.Enabled = false;
            this.groupBoxChoix.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxChoix.Location = new System.Drawing.Point(997, 12);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(200, 114);
            this.groupBoxChoix.TabIndex = 2;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // casse
            // 
            this.casse.AutoSize = true;
            this.casse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.casse.Location = new System.Drawing.Point(7, 79);
            this.casse.Name = "casse";
            this.casse.Size = new System.Drawing.Size(55, 17);
            this.casse.TabIndex = 2;
            this.casse.Text = "Casse";
            this.casse.UseVisualStyleBackColor = true;
            this.casse.CheckStateChanged += new System.EventHandler(this.choix_CheckStateChanged);
            // 
            // couleurDesCaracteres
            // 
            this.couleurDesCaracteres.AutoSize = true;
            this.couleurDesCaracteres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.couleurDesCaracteres.Location = new System.Drawing.Point(7, 56);
            this.couleurDesCaracteres.Name = "couleurDesCaracteres";
            this.couleurDesCaracteres.Size = new System.Drawing.Size(135, 17);
            this.couleurDesCaracteres.TabIndex = 1;
            this.couleurDesCaracteres.Text = "Couleur des caractères";
            this.couleurDesCaracteres.UseVisualStyleBackColor = true;
            this.couleurDesCaracteres.CheckStateChanged += new System.EventHandler(this.choix_CheckStateChanged);
            // 
            // couleurDuFond
            // 
            this.couleurDuFond.AutoSize = true;
            this.couleurDuFond.ForeColor = System.Drawing.SystemColors.ControlText;
            this.couleurDuFond.Location = new System.Drawing.Point(7, 33);
            this.couleurDuFond.Name = "couleurDuFond";
            this.couleurDuFond.Size = new System.Drawing.Size(101, 17);
            this.couleurDuFond.TabIndex = 0;
            this.couleurDuFond.Text = "Couleur du fond";
            this.couleurDuFond.UseVisualStyleBackColor = true;
            this.couleurDuFond.CheckStateChanged += new System.EventHandler(this.choix_CheckStateChanged);
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.Controls.Add(this.radioButtonFondBleu);
            this.groupBoxFond.Controls.Add(this.radioButtonFondVert);
            this.groupBoxFond.Controls.Add(this.radioButtonFondRouge);
            this.groupBoxFond.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxFond.Location = new System.Drawing.Point(43, 247);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFond.TabIndex = 3;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            this.groupBoxFond.Visible = false;
            // 
            // radioButtonFondBleu
            // 
            this.radioButtonFondBleu.AutoSize = true;
            this.radioButtonFondBleu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonFondBleu.Location = new System.Drawing.Point(7, 65);
            this.radioButtonFondBleu.Name = "radioButtonFondBleu";
            this.radioButtonFondBleu.Size = new System.Drawing.Size(46, 17);
            this.radioButtonFondBleu.TabIndex = 2;
            this.radioButtonFondBleu.TabStop = true;
            this.radioButtonFondBleu.Text = "Bleu";
            this.radioButtonFondBleu.UseVisualStyleBackColor = true;
            this.radioButtonFondBleu.CheckedChanged += new System.EventHandler(this.grpBox_CheckedChanged);
            // 
            // radioButtonFondVert
            // 
            this.radioButtonFondVert.AutoSize = true;
            this.radioButtonFondVert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonFondVert.Location = new System.Drawing.Point(7, 43);
            this.radioButtonFondVert.Name = "radioButtonFondVert";
            this.radioButtonFondVert.Size = new System.Drawing.Size(44, 17);
            this.radioButtonFondVert.TabIndex = 1;
            this.radioButtonFondVert.TabStop = true;
            this.radioButtonFondVert.Text = "Vert";
            this.radioButtonFondVert.UseVisualStyleBackColor = true;
            this.radioButtonFondVert.CheckedChanged += new System.EventHandler(this.grpBox_CheckedChanged);
            // 
            // radioButtonFondRouge
            // 
            this.radioButtonFondRouge.AutoSize = true;
            this.radioButtonFondRouge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonFondRouge.Location = new System.Drawing.Point(7, 20);
            this.radioButtonFondRouge.Name = "radioButtonFondRouge";
            this.radioButtonFondRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFondRouge.TabIndex = 0;
            this.radioButtonFondRouge.TabStop = true;
            this.radioButtonFondRouge.Text = "Rouge";
            this.radioButtonFondRouge.UseVisualStyleBackColor = false;
            this.radioButtonFondRouge.CheckedChanged += new System.EventHandler(this.grpBox_CheckedChanged);
            // 
            // groupBoxCaractere
            // 
            this.groupBoxCaractere.Controls.Add(this.radioButtonCaracNoir);
            this.groupBoxCaractere.Controls.Add(this.radioButtonCaracBlanc);
            this.groupBoxCaractere.Controls.Add(this.radioButtonCaracRouge);
            this.groupBoxCaractere.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxCaractere.Location = new System.Drawing.Point(252, 247);
            this.groupBoxCaractere.Name = "groupBoxCaractere";
            this.groupBoxCaractere.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCaractere.TabIndex = 4;
            this.groupBoxCaractere.TabStop = false;
            this.groupBoxCaractere.Text = "Caractères";
            this.groupBoxCaractere.Visible = false;
            // 
            // radioButtonCaracNoir
            // 
            this.radioButtonCaracNoir.AutoSize = true;
            this.radioButtonCaracNoir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonCaracNoir.Location = new System.Drawing.Point(6, 65);
            this.radioButtonCaracNoir.Name = "radioButtonCaracNoir";
            this.radioButtonCaracNoir.Size = new System.Drawing.Size(44, 17);
            this.radioButtonCaracNoir.TabIndex = 3;
            this.radioButtonCaracNoir.TabStop = true;
            this.radioButtonCaracNoir.Text = "Noir";
            this.radioButtonCaracNoir.UseVisualStyleBackColor = true;
            this.radioButtonCaracNoir.CheckedChanged += new System.EventHandler(this.grpboxCarac_checkedchanged);
            // 
            // radioButtonCaracBlanc
            // 
            this.radioButtonCaracBlanc.AutoSize = true;
            this.radioButtonCaracBlanc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonCaracBlanc.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCaracBlanc.Name = "radioButtonCaracBlanc";
            this.radioButtonCaracBlanc.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCaracBlanc.TabIndex = 2;
            this.radioButtonCaracBlanc.TabStop = true;
            this.radioButtonCaracBlanc.Text = "Blanc";
            this.radioButtonCaracBlanc.UseVisualStyleBackColor = true;
            this.radioButtonCaracBlanc.CheckedChanged += new System.EventHandler(this.grpboxCarac_checkedchanged);
            // 
            // radioButtonCaracRouge
            // 
            this.radioButtonCaracRouge.AutoSize = true;
            this.radioButtonCaracRouge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonCaracRouge.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCaracRouge.Name = "radioButtonCaracRouge";
            this.radioButtonCaracRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCaracRouge.TabIndex = 1;
            this.radioButtonCaracRouge.TabStop = true;
            this.radioButtonCaracRouge.Text = "Rouge";
            this.radioButtonCaracRouge.UseVisualStyleBackColor = true;
            this.radioButtonCaracRouge.CheckedChanged += new System.EventHandler(this.grpboxCarac_checkedchanged);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.Controls.Add(this.radioButtonCasseMin);
            this.groupBoxCasse.Controls.Add(this.radioButtonCasseMaj);
            this.groupBoxCasse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxCasse.Location = new System.Drawing.Point(458, 267);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(200, 80);
            this.groupBoxCasse.TabIndex = 5;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            this.groupBoxCasse.Visible = false;
            // 
            // radioButtonCasseMin
            // 
            this.radioButtonCasseMin.AutoSize = true;
            this.radioButtonCasseMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonCasseMin.Location = new System.Drawing.Point(16, 22);
            this.radioButtonCasseMin.Name = "radioButtonCasseMin";
            this.radioButtonCasseMin.Size = new System.Drawing.Size(73, 17);
            this.radioButtonCasseMin.TabIndex = 4;
            this.radioButtonCasseMin.TabStop = true;
            this.radioButtonCasseMin.Text = "Minuscule";
            this.radioButtonCasseMin.UseVisualStyleBackColor = true;
            this.radioButtonCasseMin.CheckedChanged += new System.EventHandler(this.grpboxCasse_CheckedChanged);
            // 
            // radioButtonCasseMaj
            // 
            this.radioButtonCasseMaj.AutoSize = true;
            this.radioButtonCasseMaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonCasseMaj.Location = new System.Drawing.Point(16, 46);
            this.radioButtonCasseMaj.Name = "radioButtonCasseMaj";
            this.radioButtonCasseMaj.Size = new System.Drawing.Size(73, 17);
            this.radioButtonCasseMaj.TabIndex = 5;
            this.radioButtonCasseMaj.TabStop = true;
            this.radioButtonCasseMaj.Text = "Majuscule";
            this.radioButtonCasseMaj.UseVisualStyleBackColor = true;
            this.radioButtonCasseMaj.CheckedChanged += new System.EventHandler(this.grpboxCasse_CheckedChanged);
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Location = new System.Drawing.Point(13, 146);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(0, 13);
            this.resultat.TabIndex = 6;
            // 
            // CheckboxRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 405);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxCaractere);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TaperVotreTexte);
            this.Name = "CheckboxRadio";
            this.Text = "CheckBox et RadioButton";
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBoxCaractere.ResumeLayout(false);
            this.groupBoxCaractere.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaperVotreTexte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.CheckBox casse;
        private System.Windows.Forms.CheckBox couleurDesCaracteres;
        private System.Windows.Forms.CheckBox couleurDuFond;
        private System.Windows.Forms.GroupBox groupBoxFond;
        private System.Windows.Forms.GroupBox groupBoxCaractere;
        private System.Windows.Forms.GroupBox groupBoxCasse;
        private System.Windows.Forms.RadioButton radioButtonFondBleu;
        private System.Windows.Forms.RadioButton radioButtonFondVert;
        private System.Windows.Forms.RadioButton radioButtonFondRouge;
        private System.Windows.Forms.RadioButton radioButtonCaracNoir;
        private System.Windows.Forms.RadioButton radioButtonCaracBlanc;
        private System.Windows.Forms.RadioButton radioButtonCaracRouge;
        private System.Windows.Forms.RadioButton radioButtonCasseMin;
        private System.Windows.Forms.RadioButton radioButtonCasseMaj;
        private System.Windows.Forms.Label resultat;
    }
}

