namespace ex3_jouer_avec_les_chaines
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4DerniereOccurence = new System.Windows.Forms.RadioButton();
            this.radioButton3PremiereOccurence = new System.Windows.Forms.RadioButton();
            this.radioButton2ToutesOccurences = new System.Windows.Forms.RadioButton();
            this.radioButton1NombreOccurence = new System.Windows.Forms.RadioButton();
            this.textBox1Saisie = new System.Windows.Forms.TextBox();
            this.textBox2Portion1 = new System.Windows.Forms.TextBox();
            this.textBox3Remplacement2 = new System.Windows.Forms.TextBox();
            this.textBox4Resultat = new System.Windows.Forms.TextBox();
            this.button1Jouer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Portion de chaine 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Portion de remplacement 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4DerniereOccurence);
            this.groupBox1.Controls.Add(this.radioButton3PremiereOccurence);
            this.groupBox1.Controls.Add(this.radioButton2ToutesOccurences);
            this.groupBox1.Controls.Add(this.radioButton1NombreOccurence);
            this.groupBox1.Location = new System.Drawing.Point(92, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faites votre choix";
            // 
            // radioButton4DerniereOccurence
            // 
            this.radioButton4DerniereOccurence.AutoSize = true;
            this.radioButton4DerniereOccurence.Enabled = false;
            this.radioButton4DerniereOccurence.Location = new System.Drawing.Point(21, 139);
            this.radioButton4DerniereOccurence.Name = "radioButton4DerniereOccurence";
            this.radioButton4DerniereOccurence.Size = new System.Drawing.Size(222, 17);
            this.radioButton4DerniereOccurence.TabIndex = 3;
            this.radioButton4DerniereOccurence.Text = "Remplacer dernière occurence de 1 par 2";
            this.radioButton4DerniereOccurence.UseVisualStyleBackColor = true;
            // 
            // radioButton3PremiereOccurence
            // 
            this.radioButton3PremiereOccurence.AutoSize = true;
            this.radioButton3PremiereOccurence.Enabled = false;
            this.radioButton3PremiereOccurence.Location = new System.Drawing.Point(21, 98);
            this.radioButton3PremiereOccurence.Name = "radioButton3PremiereOccurence";
            this.radioButton3PremiereOccurence.Size = new System.Drawing.Size(208, 17);
            this.radioButton3PremiereOccurence.TabIndex = 2;
            this.radioButton3PremiereOccurence.Text = "Remplacer 1ere occurrence de 1 par 2";
            this.radioButton3PremiereOccurence.UseVisualStyleBackColor = true;
            // 
            // radioButton2ToutesOccurences
            // 
            this.radioButton2ToutesOccurences.AutoSize = true;
            this.radioButton2ToutesOccurences.Enabled = false;
            this.radioButton2ToutesOccurences.Location = new System.Drawing.Point(21, 58);
            this.radioButton2ToutesOccurences.Name = "radioButton2ToutesOccurences";
            this.radioButton2ToutesOccurences.Size = new System.Drawing.Size(234, 17);
            this.radioButton2ToutesOccurences.TabIndex = 1;
            this.radioButton2ToutesOccurences.Text = "Remplacer toutes les occurences de 1 par 2";
            this.radioButton2ToutesOccurences.UseVisualStyleBackColor = true;
            // 
            // radioButton1NombreOccurence
            // 
            this.radioButton1NombreOccurence.AutoSize = true;
            this.radioButton1NombreOccurence.Checked = true;
            this.radioButton1NombreOccurence.Enabled = false;
            this.radioButton1NombreOccurence.Location = new System.Drawing.Point(21, 19);
            this.radioButton1NombreOccurence.Name = "radioButton1NombreOccurence";
            this.radioButton1NombreOccurence.Size = new System.Drawing.Size(130, 17);
            this.radioButton1NombreOccurence.TabIndex = 0;
            this.radioButton1NombreOccurence.TabStop = true;
            this.radioButton1NombreOccurence.Text = "Nombre occurences 1";
            this.radioButton1NombreOccurence.UseVisualStyleBackColor = true;
            // 
            // textBox1Saisie
            // 
            this.textBox1Saisie.Location = new System.Drawing.Point(266, 39);
            this.textBox1Saisie.Name = "textBox1Saisie";
            this.textBox1Saisie.Size = new System.Drawing.Size(357, 20);
            this.textBox1Saisie.TabIndex = 5;
            this.textBox1Saisie.TextChanged += new System.EventHandler(this.textBox1Saisie_TextChanged);
            // 
            // textBox2Portion1
            // 
            this.textBox2Portion1.Enabled = false;
            this.textBox2Portion1.Location = new System.Drawing.Point(266, 87);
            this.textBox2Portion1.Name = "textBox2Portion1";
            this.textBox2Portion1.Size = new System.Drawing.Size(357, 20);
            this.textBox2Portion1.TabIndex = 6;
            this.textBox2Portion1.TextChanged += new System.EventHandler(this.textBox2Portion1_TextChanged);
            // 
            // textBox3Remplacement2
            // 
            this.textBox3Remplacement2.Enabled = false;
            this.textBox3Remplacement2.Location = new System.Drawing.Point(266, 139);
            this.textBox3Remplacement2.Name = "textBox3Remplacement2";
            this.textBox3Remplacement2.Size = new System.Drawing.Size(357, 20);
            this.textBox3Remplacement2.TabIndex = 7;
            this.textBox3Remplacement2.TextChanged += new System.EventHandler(this.textBox3Remplacement2_TextChanged);
            // 
            // textBox4Resultat
            // 
            this.textBox4Resultat.Enabled = false;
            this.textBox4Resultat.Location = new System.Drawing.Point(266, 192);
            this.textBox4Resultat.Name = "textBox4Resultat";
            this.textBox4Resultat.Size = new System.Drawing.Size(357, 20);
            this.textBox4Resultat.TabIndex = 8;
            // 
            // button1Jouer
            // 
            this.button1Jouer.Enabled = false;
            this.button1Jouer.Location = new System.Drawing.Point(113, 441);
            this.button1Jouer.Name = "button1Jouer";
            this.button1Jouer.Size = new System.Drawing.Size(75, 23);
            this.button1Jouer.TabIndex = 9;
            this.button1Jouer.Text = "Jouer";
            this.button1Jouer.UseVisualStyleBackColor = true;
            this.button1Jouer.Click += new System.EventHandler(this.button1Jouer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 497);
            this.Controls.Add(this.button1Jouer);
            this.Controls.Add(this.textBox4Resultat);
            this.Controls.Add(this.textBox3Remplacement2);
            this.Controls.Add(this.textBox2Portion1);
            this.Controls.Add(this.textBox1Saisie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4DerniereOccurence;
        private System.Windows.Forms.RadioButton radioButton3PremiereOccurence;
        private System.Windows.Forms.RadioButton radioButton2ToutesOccurences;
        private System.Windows.Forms.RadioButton radioButton1NombreOccurence;
        private System.Windows.Forms.TextBox textBox1Saisie;
        private System.Windows.Forms.TextBox textBox2Portion1;
        private System.Windows.Forms.TextBox textBox3Remplacement2;
        private System.Windows.Forms.TextBox textBox4Resultat;
        private System.Windows.Forms.Button button1Jouer;
    }
}

