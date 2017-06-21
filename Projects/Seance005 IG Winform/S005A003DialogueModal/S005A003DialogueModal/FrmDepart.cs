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
    public partial class FrmDepart : Form
    {
        public FrmDepart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Identification DialogueModal = new Identification();
            DialogResult resultat = DialogueModal.ShowDialog();
            switch (resultat)
            {
                case DialogResult.None:
                   DialogueModal.ShowDialog();
                    break;

                case DialogResult.OK:
                    textBox1.Text = "Identification réussie";
                    break;

                case DialogResult.Cancel:
                    textBox1.Text = "Identification échouée";
                    break;

               


            }
        }
    }
}
