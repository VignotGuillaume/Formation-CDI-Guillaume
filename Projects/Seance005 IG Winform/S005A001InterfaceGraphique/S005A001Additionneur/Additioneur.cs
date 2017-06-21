using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace S005A001Additionneur
{
    public partial class Additioneur : Form
    {


        const string TexteInitial = "Cliquez sur les valeurs a additionner";
        int calcul;

        public Additioneur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            textBox1.Text += "="+ calcul + "+";
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            textBox1.Text = TexteInitial;
            calcul = 0;

        }   


        private void button_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == TexteInitial)
            {
                textBox1.Clear();
            }


            string affichageNombre = ((Button)sender).Text;
            textBox1.Text += affichageNombre+"+";

            int nombreConverti = Int32.Parse(affichageNombre);
             calcul= calcul+ nombreConverti;

        }

        private void Additioneur_FormClosing(object sender, FormClosingEventArgs e)
        {

          
                Debug.WriteLine("Fin de l’application additionneur");
           
        }
    }

}
