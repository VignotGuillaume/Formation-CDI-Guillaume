namespace GestionSalaraies
{
    partial class FrmSalaries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxSalaireBrut = new System.Windows.Forms.TextBox();
            this.comboBox1ListeSalarie = new System.Windows.Forms.ComboBox();
            this.button1Nouveau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDatedeNaissance = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCommission = new System.Windows.Forms.TextBox();
            this.textBoxChiffreAffaire = new System.Windows.Forms.TextBox();
            this.textBoxTauxCS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2Modifier = new System.Windows.Forms.Button();
            this.button3Annuler = new System.Windows.Forms.Button();
            this.button4Valider = new System.Windows.Forms.Button();
            this.epSalarie = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSalarie)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.Location = new System.Drawing.Point(128, 19);
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(168, 20);
            this.textBoxMatricule.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(128, 45);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(168, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(128, 71);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(168, 20);
            this.textBoxPrenom.TabIndex = 6;
            // 
            // textBoxSalaireBrut
            // 
            this.textBoxSalaireBrut.Location = new System.Drawing.Point(128, 123);
            this.textBoxSalaireBrut.Name = "textBoxSalaireBrut";
            this.textBoxSalaireBrut.Size = new System.Drawing.Size(168, 20);
            this.textBoxSalaireBrut.TabIndex = 7;
            // 
            // comboBox1ListeSalarie
            // 
            this.comboBox1ListeSalarie.FormattingEnabled = true;
            this.comboBox1ListeSalarie.Location = new System.Drawing.Point(175, 36);
            this.comboBox1ListeSalarie.Name = "comboBox1ListeSalarie";
            this.comboBox1ListeSalarie.Size = new System.Drawing.Size(121, 21);
            this.comboBox1ListeSalarie.TabIndex = 9;
            this.comboBox1ListeSalarie.SelectedIndexChanged += new System.EventHandler(this.comboBox1ListeSalarie_SelectedIndexChanged);
            // 
            // button1Nouveau
            // 
            this.button1Nouveau.Location = new System.Drawing.Point(350, 34);
            this.button1Nouveau.Name = "button1Nouveau";
            this.button1Nouveau.Size = new System.Drawing.Size(75, 23);
            this.button1Nouveau.TabIndex = 10;
            this.button1Nouveau.Text = "Nouveau";
            this.button1Nouveau.UseVisualStyleBackColor = true;
            this.button1Nouveau.Click += new System.EventHandler(this.button1Nouveau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choisir un salarie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDatedeNaissance);
            this.groupBox1.Controls.Add(this.textBoxCommission);
            this.groupBox1.Controls.Add(this.textBoxChiffreAffaire);
            this.groupBox1.Controls.Add(this.textBoxTauxCS);
            this.groupBox1.Controls.Add(this.textBoxSalaireBrut);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.textBoxMatricule);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.textBoxPrenom);
            this.groupBox1.Location = new System.Drawing.Point(36, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 344);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details Salarie";
            // 
            // textBoxDatedeNaissance
            // 
            this.textBoxDatedeNaissance.Location = new System.Drawing.Point(128, 97);
            this.textBoxDatedeNaissance.Mask = "00/00/0000";
            this.textBoxDatedeNaissance.Name = "textBoxDatedeNaissance";
            this.textBoxDatedeNaissance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatedeNaissance.TabIndex = 24;
            this.textBoxDatedeNaissance.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxCommission
            // 
            this.textBoxCommission.Enabled = false;
            this.textBoxCommission.Location = new System.Drawing.Point(128, 209);
            this.textBoxCommission.Name = "textBoxCommission";
            this.textBoxCommission.Size = new System.Drawing.Size(168, 20);
            this.textBoxCommission.TabIndex = 23;
            // 
            // textBoxChiffreAffaire
            // 
            this.textBoxChiffreAffaire.Enabled = false;
            this.textBoxChiffreAffaire.Location = new System.Drawing.Point(128, 180);
            this.textBoxChiffreAffaire.Name = "textBoxChiffreAffaire";
            this.textBoxChiffreAffaire.Size = new System.Drawing.Size(168, 20);
            this.textBoxChiffreAffaire.TabIndex = 22;
            // 
            // textBoxTauxCS
            // 
            this.textBoxTauxCS.Location = new System.Drawing.Point(128, 151);
            this.textBoxTauxCS.Name = "textBoxTauxCS";
            this.textBoxTauxCS.Size = new System.Drawing.Size(168, 20);
            this.textBoxTauxCS.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(26, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Commission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(26, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Chiffre d\'Affaire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "TauxCS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salaire Brut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date De Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matricule";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2Modifier);
            this.flowLayoutPanel1.Controls.Add(this.button3Annuler);
            this.flowLayoutPanel1.Controls.Add(this.button4Valider);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 254);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 61);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // button2Modifier
            // 
            this.button2Modifier.Location = new System.Drawing.Point(3, 3);
            this.button2Modifier.Name = "button2Modifier";
            this.button2Modifier.Size = new System.Drawing.Size(108, 23);
            this.button2Modifier.TabIndex = 0;
            this.button2Modifier.Text = "Modifier";
            this.button2Modifier.UseVisualStyleBackColor = true;
            this.button2Modifier.Click += new System.EventHandler(this.button2Modifier_Click);
            // 
            // button3Annuler
            // 
            this.button3Annuler.Location = new System.Drawing.Point(117, 3);
            this.button3Annuler.Name = "button3Annuler";
            this.button3Annuler.Size = new System.Drawing.Size(114, 23);
            this.button3Annuler.TabIndex = 1;
            this.button3Annuler.Text = "Annuler";
            this.button3Annuler.UseVisualStyleBackColor = true;
            this.button3Annuler.Click += new System.EventHandler(this.button3Annuler_Click);
            // 
            // button4Valider
            // 
            this.button4Valider.Location = new System.Drawing.Point(237, 3);
            this.button4Valider.Name = "button4Valider";
            this.button4Valider.Size = new System.Drawing.Size(111, 23);
            this.button4Valider.TabIndex = 2;
            this.button4Valider.Text = "Valider";
            this.button4Valider.UseVisualStyleBackColor = true;
            this.button4Valider.Click += new System.EventHandler(this.button4Valider_Click);
            // 
            // epSalarie
            // 
            this.epSalarie.ContainerControl = this;
            // 
            // FrmSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Nouveau);
            this.Controls.Add(this.comboBox1ListeSalarie);
            this.Name = "FrmSalaries";
            this.Text = "Gestion des Salariés";
            this.Load += new System.EventHandler(this.FrmSalaries_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epSalarie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatricule;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxSalaireBrut;
        private System.Windows.Forms.ComboBox comboBox1ListeSalarie;
        private System.Windows.Forms.Button button1Nouveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCommission;
        private System.Windows.Forms.TextBox textBoxChiffreAffaire;
        private System.Windows.Forms.TextBox textBoxTauxCS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2Modifier;
        private System.Windows.Forms.Button button3Annuler;
        private System.Windows.Forms.Button button4Valider;
        private System.Windows.Forms.ErrorProvider epSalarie;
        private System.Windows.Forms.MaskedTextBox textBoxDatedeNaissance;
    }
}