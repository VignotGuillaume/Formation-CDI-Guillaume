namespace S005A003DialogueModal
{
    partial class Identification
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxParam = new System.Windows.Forms.GroupBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Connect = new System.Windows.Forms.Button();
            this.button2Quit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxParam
            // 
            this.groupBoxParam.Controls.Add(this.textBoxMDP);
            this.groupBoxParam.Controls.Add(this.textBoxID);
            this.groupBoxParam.Controls.Add(this.label2);
            this.groupBoxParam.Controls.Add(this.label1);
            this.groupBoxParam.Location = new System.Drawing.Point(22, 22);
            this.groupBoxParam.Name = "groupBoxParam";
            this.groupBoxParam.Size = new System.Drawing.Size(252, 123);
            this.groupBoxParam.TabIndex = 0;
            this.groupBoxParam.TabStop = false;
            this.groupBoxParam.Text = "Paramètres d\'authentification";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(96, 77);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.PasswordChar = '*';
            this.textBoxMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxMDP.TabIndex = 3;
            this.textBoxMDP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMDP_Validating);
            // 
            // textBoxID
            // 
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxID.Location = new System.Drawing.Point(96, 42);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxID_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID utilisateur";
            // 
            // button1Connect
            // 
            this.button1Connect.Location = new System.Drawing.Point(22, 166);
            this.button1Connect.Name = "button1Connect";
            this.button1Connect.Size = new System.Drawing.Size(86, 23);
            this.button1Connect.TabIndex = 1;
            this.button1Connect.Text = "Se connecter";
            this.button1Connect.UseVisualStyleBackColor = true;
            this.button1Connect.Click += new System.EventHandler(this.button1Connect_Click);
            // 
            // button2Quit
            // 
            this.button2Quit.CausesValidation = false;
            this.button2Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2Quit.Location = new System.Drawing.Point(198, 165);
            this.button2Quit.Name = "button2Quit";
            this.button2Quit.Size = new System.Drawing.Size(75, 23);
            this.button2Quit.TabIndex = 2;
            this.button2Quit.Text = "Quitter";
            this.button2Quit.UseVisualStyleBackColor = true;
            this.button2Quit.Click += new System.EventHandler(this.button2Quit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 240);
            this.ControlBox = false;
            this.Controls.Add(this.button2Quit);
            this.Controls.Add(this.button1Connect);
            this.Controls.Add(this.groupBoxParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(305, 240);
            this.MinimumSize = new System.Drawing.Size(305, 240);
            this.Name = "Identification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identifiez-vous";
            this.groupBoxParam.ResumeLayout(false);
            this.groupBoxParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParam;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Connect;
        private System.Windows.Forms.Button button2Quit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

