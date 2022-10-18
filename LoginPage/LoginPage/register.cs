using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
     
        private void LabelLogin_Click_1(object sender, EventArgs e)
        {
            LoginForm fr = new LoginForm();
            this.Hide();
            fr.Show();
       }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtConfrmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "" || TxtPassword.Text == "" || TxtConfrmPassword.Text == "")
            {
                MessageBox.Show("Please Fill Each Field!", "Register Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPassword.Text == TxtConfrmPassword.Text)
            {
                Account ac = AccountClass.Register(TxtUsername.Text, TxtPassword.Text);
                MessageBox.Show("User Created Successfully!");
            }
            else
            {
                MessageBox.Show("Passwords Dont Match!", "Register error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChckBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckBxShowPass.Checked)
            {
                TxtPassword.PasswordChar = '\0';
                TxtConfrmPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                TxtConfrmPassword.PasswordChar = '*';
            }
        }
    }
}
