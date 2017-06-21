using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance005Atelier002
{
    public partial class Damier_8x8_NB : Form
    {
        public Damier_8x8_NB()
        {
            InitializeComponent();
        }

       

        private void Damier_8x8_NB_Load(object sender, EventArgs e)
        {
            int couleur = 0;

            for (int h = 0; h < 8; h++)
            {

                int l = 0;
                for (l = 0; l < 8; l++)
                {
                    int modulo = (l + h) % 2;
                    couleur = couleur + 1;
                    Button carreNoir = new Button();
                    if (modulo == 0)
                    {
                        carreNoir.BackColor = Color.Black;
                    }
                    else
                    {
                        carreNoir.BackColor = Color.White;
                    }

                    carreNoir.Size = new System.Drawing.Size(50, 50);
                    carreNoir.Left = l * (carreNoir.Width);
                    carreNoir.Top = h * (carreNoir.Height);

                    this.panelDamier.Controls.Add(carreNoir);

                }




            }
        }
    }
}
