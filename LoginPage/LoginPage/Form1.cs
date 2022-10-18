using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChckBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
           if (ChckBxShowPass.Checked)
            {
                TxtPassword.PasswordChar = '\0';
            }
           else
            {
                TxtPassword.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            Account signedInAcc = AccountClass.Login(TxtUsername.Text, TxtPassword.Text);
            if (signedInAcc == null)
            {
                MessageBox.Show("Invalid User Credentials!", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUsername.Text = "";
                TxtPassword.Text = "";
                return;
            }

            CaptchaForm frm = new CaptchaForm();
            this.Hide();
            frm.Show();
        }

        private void LabelRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            this.Hide();
            frm.Show();
        }
    }
}
