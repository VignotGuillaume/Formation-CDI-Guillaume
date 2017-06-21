namespace S005A003DialogueModalEx1
{
    partial class FrmDialogueModal2
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
            this.button1OK = new System.Windows.Forms.Button();
            this.button2Abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1OK
            // 
            this.button1OK.Location = new System.Drawing.Point(0, 0);
            this.button1OK.Name = "button1OK";
            this.button1OK.Size = new System.Drawing.Size(75, 23);
            this.button1OK.TabIndex = 0;
            this.button1OK.Text = "OK";
            this.button1OK.UseVisualStyleBackColor = true;
            // 
            // button2Abort
            // 
            this.button2Abort.Location = new System.Drawing.Point(0, 56);
            this.button2Abort.Name = "button2Abort";
            this.button2Abort.Size = new System.Drawing.Size(75, 23);
            this.button2Abort.TabIndex = 1;
            this.button2Abort.Text = "Abandon";
            this.button2Abort.UseVisualStyleBackColor = true;
            // 
            // FrmDialogueModal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2Abort);
            this.Controls.Add(this.button1OK);
            this.Name = "FrmDialogueModal2";
            this.Text = "FrmDialogueModal2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1OK;
        private System.Windows.Forms.Button button2Abort;
    }
}