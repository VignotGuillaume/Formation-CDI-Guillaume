using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S005A001InterfaceGraphique
{
    public partial class Recopier : Form
    {
        public Recopier()
        {
            InitializeComponent();
        }

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        private void btnRecopier_Click(object sender, EventArgs e)
        {
            texteCopie.Text = texteARecopier.Text;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            texteCopie.Text = " ";
            texteARecopier.Text = "Entrer le texte initial";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
