using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_jouer_avec_les_caractere_d_une_chaine_de_caractere_
{
    public partial class categorieDuCaractere : Form
    {
        const string PhraseDeDepart = "Saisissez ici une chaine de caractere";


        public categorieDuCaractere()
        {
            InitializeComponent();
        }

        private void textBoxSaisir_TextChanged(object sender, EventArgs e)
        {


            if (textBoxSaisir.Text != PhraseDeDepart && textBoxSaisir.Text != "")
            {

                numericUpDown.Enabled = true;
                numericUpDown.Maximum = textBoxSaisir.Text.Length;

            }
            else
            {
                numericUpDown.Enabled = false;

            }

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Value != 0)
            {

                button.Enabled = true;



            }
            else
            {
                button.Enabled = false;

            }


        }



        private void button_Click(object sender, EventArgs e)
        {
            
            textBoxResultat.Enabled = true;
            int valeur = (int)numericUpDown.Value;
            string phrase = textBoxSaisir.Text;
            char caractere = phrase[valeur - 1];
            if (char.IsLetter(caractere))
            {

                string lettre = "lettre : " + caractere.ToString();
                textBoxResultat.Text = lettre;
            }
            if (char.IsNumber(caractere))
            {
                string chiffre = "Chiffre : " + caractere.ToString();
                textBoxResultat.Text = chiffre;

            }
            if (char.IsPunctuation(caractere))
            {
                string ponctuation = "Ponctuation : " + caractere.ToString();
                textBoxResultat.Text = ponctuation;

            }

            if (char.IsSymbol(caractere))
            {
                string symbole = "Symbole : " + caractere.ToString();
                textBoxResultat.Text = symbole;

            }
            if (char.IsWhiteSpace(caractere))
            {
                string espace = "Espace : " + caractere.ToString() + "";
                textBoxResultat.Text = espace;

            }



        }


    }
}
