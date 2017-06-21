using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S005A003DialogueModalEx1
{
    public partial class FrmDialogueModal : Form
    {
        public FrmDialogueModal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDialogueModal2 DialogueModal = new FrmDialogueModal2();
            DialogResult resultat = DialogueModal.ShowDialog();
            switch (resultat)
            {

                case DialogResult.OK:
                    textBox1.Text = "ok";
                    break;

                case DialogResult.Abort:
                    textBox1.Text = "Abandon";
                    break;


            }
           





        }


    }
}
