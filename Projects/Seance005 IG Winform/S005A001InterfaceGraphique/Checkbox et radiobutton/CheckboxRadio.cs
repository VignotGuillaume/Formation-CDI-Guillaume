using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Checkbox_et_radiobutton
{
    public partial class CheckboxRadio : Form
    {
        const string PhraseDeDepart = "Salut tout le monde";
        public CheckboxRadio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != PhraseDeDepart && textBox1.Text != "")
            {
                groupBoxChoix.Enabled = true;              

                resultat.Text = textBox1.Text;
               

            }
            else
            {
                groupBoxChoix.Enabled = false;
                resultat.Text = textBox1.Text;
                resultat.BackColor = Color.Empty;
                resultat.ForeColor = Color.Empty;
                 

            }
            if (radioButtonCasseMaj.Checked)
            {
                resultat.Text = textBox1.Text.ToUpper();
            }
            if (radioButtonCasseMin.Checked)
            {
                resultat.Text = textBox1.Text.ToLower();
            }
        }

        private void choix_CheckStateChanged(object sender, EventArgs e)
        {
            if (couleurDuFond.Checked)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                groupBoxFond.Visible = false;
                resultat.BackColor = Color.Empty;
                resultat.Text = textBox1.Text;
            }

            if (couleurDesCaracteres.Checked)
            {
                groupBoxCaractere.Visible = true;
            }
            else
            {
                groupBoxCaractere.Visible = false;
                resultat.ForeColor = Color.Empty;
            }
            if (casse.Checked)
            {
                groupBoxCasse.Visible = true;
            }
            else
            {
                groupBoxCasse.Visible = false;
                resultat.Text = textBox1.Text;

            }


        }

        private void grpBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondRouge.Checked)
            {
                resultat.BackColor = Color.Red;
                resultat.Text = textBox1.Text;
            }
            if (radioButtonFondVert.Checked)
            {
                resultat.BackColor = Color.Green;
                resultat.Text = textBox1.Text;
            }
            if (radioButtonFondBleu.Checked)
            {
                resultat.BackColor = Color.Blue;
                resultat.Text = textBox1.Text;
            }
            
         
        }

        private void grpboxCarac_checkedchanged(object sender, EventArgs e)
        {
            if (radioButtonCaracRouge.Checked)
            {
                resultat.ForeColor = Color.Red;
                resultat.Text = textBox1.Text;
            }
            if (radioButtonCaracBlanc.Checked)
            {
                resultat.ForeColor = Color.White;
                resultat.Text = textBox1.Text;
            }
            if (radioButtonCaracNoir.Checked)
            {
                resultat.ForeColor = Color.Black;
                resultat.Text = textBox1.Text;
            }
        }

        private void grpboxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCasseMin.Checked)
            {
                resultat.Text = textBox1.Text.ToLower();
 
            }

            if (radioButtonCasseMaj.Checked)
            {
                resultat.Text = textBox1.Text.ToUpper();

            }
        }



    }
}
       