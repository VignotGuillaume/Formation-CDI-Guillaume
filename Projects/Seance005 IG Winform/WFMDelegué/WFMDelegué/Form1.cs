using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalarieDll;

namespace WFMDelegué
{
    public partial class Form1 : Form
    {
        Salarie _sa1 = new Salarie() {SalaireBrut=1400 };

        public  Form1()
        {
            InitializeComponent();
            _sa1.ChangementSalaire += _sa1_ChangementSalaire;
            int tauxAugment = 10;
            _sa1.SalaireBrut +=tauxAugment;
            textBox2.Text = tauxAugment.ToString();
        }

        private void _sa1_ChangementSalaire(object sender, ChangementSalaireEventArgs e)
        {
            textBox1.Text = e.AncienSalaire.ToString("0.00");
            textBox3.Text = e.NouveauSalaire.ToString();
        }
    }
     

}


