namespace S05A_002_2
{
    partial class frmLogin
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
            this.gbParam = new System.Windows.Forms.GroupBox();
            this.ltPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbParam.SuspendLayout();
            this.ltPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbParam
            // 
            this.gbParam.Controls.Add(this.ltPanel);
            this.gbParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParam.Location = new System.Drawing.Point(10, 10);
            this.gbParam.Margin = new System.Windows.Forms.Padding(10);
            this.gbParam.Name = "gbParam";
            this.gbParam.Size = new System.Drawing.Size(418, 99);
            this.gbParam.TabIndex = 0;
            this.gbParam.TabStop = false;
            this.gbParam.Text = "Paramètres d\'authentification";
            // 
            // ltPanel
            // 
            this.ltPanel.ColumnCount = 2;
            this.ltPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.29167F));
            this.ltPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.70834F));
            this.ltPanel.Controls.Add(this.txtPass, 1, 1);
            this.ltPanel.Controls.Add(this.labLogin, 0, 0);
            this.ltPanel.Controls.Add(this.labPass, 0, 1);
            this.ltPanel.Controls.Add(this.txtlogin, 1, 0);
            this.ltPanel.Location = new System.Drawing.Point(6, 19);
            this.ltPanel.Name = "ltPanel";
            this.ltPanel.RowCount = 2;
            this.ltPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ltPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ltPanel.Size = new System.Drawing.Size(406, 72);
            this.ltPanel.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(134, 41);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 5, 15, 3);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '°';
            this.txtPass.Size = new System.Drawing.Size(257, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Tag = "Pass";
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Location = new System.Drawing.Point(3, 10);
            this.labLogin.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(65, 13);
            this.labLogin.TabIndex = 0;
            this.labLogin.Text = "ID utilisateur";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Location = new System.Drawing.Point(3, 46);
            this.labPass.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(71, 13);
            this.labPass.TabIndex = 1;
            this.labPass.Text = "Mot de passe";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(134, 5);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(3, 5, 15, 3);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(257, 20);
            this.txtlogin.TabIndex = 2;
            this.txtlogin.Tag = "Login";
            this.txtlogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtlogin_Validating);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuitter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnection, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 69);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnQuitter
            // 
            this.btnQuitter.AutoSize = true;
            this.btnQuitter.CausesValidation = false;
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitter.Location = new System.Drawing.Point(219, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(210, 63);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.AutoSize = true;
            this.btnConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnection.Location = new System.Drawing.Point(3, 3);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(210, 63);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Se connecter";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbParam, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.76471F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.23529F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 194);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 194);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Identifiez-vous";
            this.gbParam.ResumeLayout(false);
            this.ltPanel.ResumeLayout(false);
            this.ltPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParam;
        private System.Windows.Forms.TableLayoutPanel ltPanel;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

