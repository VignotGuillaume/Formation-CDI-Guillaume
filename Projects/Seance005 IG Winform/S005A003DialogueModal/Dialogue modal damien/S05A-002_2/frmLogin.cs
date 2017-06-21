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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnConnection;
            this.CancelButton = btnQuitter;
        }

        private void txtlogin_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !test_Login();
        }
        public bool test_Login()
        {
            errorProvider1.SetError(txtlogin, string.Empty);
            if (txtlogin.Text == string.Empty)
            {
                errorProvider1.SetError(txtlogin, "ne doit pas être vide !");
                return false;
            }
            else
            {
                if (char.IsNumber(txtlogin.Text.First<char>()))
                {
                    errorProvider1.SetError(txtlogin, "doit être une lettre en premier !");
                    return false;
                }
                if (txtlogin.Text.Length < 5)
                {
                    errorProvider1.SetError(txtlogin, "doit être de minimum 5 caractères !");
                    return false;
                }
            }
            errorProvider1.SetError(txtlogin, string.Empty);
            return true;
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !test_Pass();
        }
        public bool test_Pass()
        {
            errorProvider1.SetError(txtPass, string.Empty);
            if (txtPass.Text == string.Empty)
            {
                errorProvider1.SetError(txtPass, "ne doit pas être vide !");
                return false;
            }
            else
            {
                if (txtPass.Text.Length < 5)
                {
                    errorProvider1.SetError(txtPass, "doit être de minimum 5 caractères !");
                    return false;
                }
                if (txtPass.Text != txtlogin.Text)
                {
                    errorProvider1.SetError(txtPass, "doit être égal au login !");
                    return false;
                }
            }
            errorProvider1.SetError(txtPass, string.Empty);
            return true;
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (test_Login() & test_Pass()) DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.None;
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
