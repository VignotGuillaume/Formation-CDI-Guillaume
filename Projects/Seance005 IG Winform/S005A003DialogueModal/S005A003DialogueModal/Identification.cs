using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S005A003DialogueModal
{
    public partial class Identification : Form
    {
        public Identification()
        {
            InitializeComponent();


        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            if (isIDValide())
            {
                this.errorProvider1.SetError(textBoxID, "Doit commencer par une lettre, etre de type alphanumeric,et contenir au moins 5 caractere");
                e.Cancel = true;

            }
            else
            {

                this.errorProvider1.SetError(textBoxID,string.Empty);
            }
        }


        private bool isIDValide()
        {
           

                if (!string.IsNullOrEmpty(textBoxID.Text) && textBoxID.Text.Length >= 5 && char.IsLetter(textBoxID.Text[0]))
            {

                for (int i = 0; i < textBoxID.Text.Length; i++)
                {
                    if (!char.IsLetter(textBoxID.Text[i]) || !char.IsDigit(textBoxID.Text[i]) )
                    {

                        return false;
                    }

                }

            }
            return true;
        }



        private void textBoxMDP_Validating(object sender, CancelEventArgs e)
        {
            if (isMDPValide())
            {
                this.errorProvider1.SetError(textBoxMDP, "Mot de passe doit etre egale a ID");
                e.Cancel = true;
            }
            else
            {

                this.errorProvider1.SetError(textBoxMDP, string.Empty);
            }
        }

        private bool isMDPValide()
        {

            if (!string.IsNullOrEmpty(textBoxMDP.Text) && textBoxMDP.Text.Length >= 5)
            {

                return false;

            }
            return true;

        }

        private void button1Connect_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == textBoxMDP.Text)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void button2Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
