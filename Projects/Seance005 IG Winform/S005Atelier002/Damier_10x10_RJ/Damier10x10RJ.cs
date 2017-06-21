using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damier_10x10_RJ
{
    public partial class Damier10x10RJ : Form
    {
        public Damier10x10RJ()
        {
            InitializeComponent();
        }

        

        private void Damier10x10RJ_Load(object sender, EventArgs e)
        {
            int couleur = 0;

            for (int h = 0; h < 10; h++)
            {


                for (int l = 0; l < 11; l++)
                {
                    int modulo = (l + h) % 2;
                    couleur = couleur + 1;
                    Button carreNoir = new Button();
                    if (modulo == 0)
                    {
                        carreNoir.BackColor = Color.Yellow;
                    }
                    else
                    {
                        carreNoir.BackColor = Color.Red;
                    }

                    carreNoir.Size = new System.Drawing.Size(50, 50);
                    carreNoir.Left = l * (carreNoir.Width);
                    carreNoir.Top = h * (carreNoir.Height);

                    this.PanelRJ.Controls.Add(carreNoir);

                }




            }
        }
    }
}
