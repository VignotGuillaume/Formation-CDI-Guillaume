using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalaraies
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }

        
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            DialConnexion DialogueModal = new DialConnexion();
            //  DialogResult resultat = DialogueModal.ShowDialog();
            DialogResult resultat = DialogResult.OK;
            switch (resultat)
            {
                case DialogResult.None:
                    DialogueModal.ShowDialog();
                    break;

                case DialogResult.OK:
                    gestionToolStripMenuItem.Enabled = true;
                    break;

                case DialogResult.Cancel:
                    DialogueModal.Close();
                    Close();     
                    break;




            }

        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUtilisateurs frmUtilisateurs = new FrmUtilisateurs();
            frmUtilisateurs.MdiParent = this;
            frmUtilisateurs.Show();
        }

        private void gestionDesSalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalaries frmSalaries = new FrmSalaries();
            frmSalaries.MdiParent = this;
            frmSalaries.Show();
        }
    }
}
