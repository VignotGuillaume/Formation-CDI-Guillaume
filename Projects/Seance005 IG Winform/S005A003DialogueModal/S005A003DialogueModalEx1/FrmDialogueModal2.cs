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
    public partial class FrmDialogueModal2 : Form
    {
        public FrmDialogueModal2()
        {
            InitializeComponent();
            button1OK.DialogResult = DialogResult.OK;
            button2Abort.DialogResult = DialogResult.Abort;
        }

        
    }
}
