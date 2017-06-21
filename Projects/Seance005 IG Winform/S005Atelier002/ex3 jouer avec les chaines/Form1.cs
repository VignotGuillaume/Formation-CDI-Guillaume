using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_jouer_avec_les_chaines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1Saisie_TextChanged(object sender, EventArgs e)
        {
            if (textBox1Saisie.Text != "")
            {
                textBox2Portion1.Enabled = true;
            }
        }

        private void textBox2Portion1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2Portion1.Text != "")
            {
                textBox3Remplacement2.Enabled = true;
                radioButton1NombreOccurence.Enabled = true;
                button1Jouer.Enabled = true;
            }
            else
            {
                textBox3Remplacement2.Enabled = false;
                radioButton1NombreOccurence.Enabled = false;
                button1Jouer.Enabled = false;
            }
        }

        private void textBox3Remplacement2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3Remplacement2.Text != "")
            {
                radioButton2ToutesOccurences.Enabled = true;
                radioButton3PremiereOccurence.Enabled = true;
                radioButton4DerniereOccurence.Enabled = true;
            }
            else
            {
                radioButton2ToutesOccurences.Enabled = false;
                radioButton3PremiereOccurence.Enabled = false;
                radioButton4DerniereOccurence.Enabled = false;
            }
        }




    }

    private void button1Jouer_Click(object sender, EventArgs e)
    {



        switch ()
        {
            case radioButton1NombreOccurence.Checked:

                string origine;
                string recherchee;
                origine = textBox1Saisie.Text;
                recherchee = textBox2Portion1.Text;
                int occurences = compterOccurences(origine, recherchee);


                int nbOccurences = 0;
                int pos = 0;
                while (recherchee != string.Empty && pos != -1)
                {
                    pos = origine.IndexOf(recherchee, pos);
                    if (pos != -1)
                    {
                        nbOccurences++;
                        pos += recherchee.Length;
                    }
                }
                return nbOccurences;
                break



            case radioButton2ToutesOccurences.Checked:


                    int pospremiere = origine.indexof(recherchee);
                    return origine.Replace(recherchee, remplacement);

                break;

            case radioButton3PremiereOccurence.Checked:
                string remplacement = textbox3
    //    string nouvellechaine = replaceALL(origine, recherchee, remplacement);
    //    nouvellechaine = replaceFirst(origine, recherchee, remplacement);

                int pospremiere = origine.indexof(recherchee);
                    return (pospremiere = -1) || recherchee == string.Empty)?   origine: origine.remove(pospremiere, recherchee.lenght).insert(pospremiere, remplacement);
                break;
            case radioButton4DerniereOccurence.Checked:
                break;




   }

        }

    //public static main()
    //{


    //    string origine;
    //    string recherchee;
    //    origine = textBox1Saisie.Text;
    //    recherchee = textBox2Portion1.Text;
    //    int occurences = compterOccurences(origine, recherchee);

    //    string remplacement = textbox3
    //    string nouvellechaine = replaceALL(origine, recherchee, remplacement);
    //    nouvellechaine = replaceFirst(origine, recherchee, remplacement);

    //}



    //private string replaceALL(object origine, object recherchee, object remplacement)
    //{
    //    int pospremiere = origine.indexof(recherchee);
    //    return origine.Replace(recherchee, remplacement);
    //}





    //private string replaceFirst(object origine, object recherchee, object remplacement)
    //{
    //    int pospremiere = origine.indexof(recherchee);
    //    return (pospremiere = -1) || recherchee == string.Empty)?   origine: origine.remove(pospremiere, recherchee.lenght).insert(pospremiere, remplacement);
    //}






    //private static int compterOccurences(string origine, string recherchee)
    //{
    //    int nbOccurences = 0;
    //    int pos = 0;
    //    while (recherchee != string.Empty && pos != -1)
    //    {
    //        pos = origine.IndexOf(recherchee, pos);
    //        if (pos != -1)
    //        {
    //            nbOccurences++;
    //            pos += recherchee.Length;
    //        }
    //    }
    //    return nbOccurences;
    //}
}
}
