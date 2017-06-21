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

namespace S05A_002_2
{
    public partial class frmApp : Form
    {
        frmLogin login = new frmLogin();
        public frmApp()
        {
            InitializeComponent();

            DialogResult result = login.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    label1.Text = "OK";
                    break;
                case DialogResult.Cancel:
                    label1.Text = "Cancel";
                    break;
            }
        }
    }
}
