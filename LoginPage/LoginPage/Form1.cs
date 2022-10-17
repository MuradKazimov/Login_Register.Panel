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
        private bool isPasswordVisible = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChckBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            TxtPassword.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           
        }

        private void LabelRegister_Click(object sender, EventArgs e)
        {
            RegisterForm fr = new RegisterForm();
            this.Hide();
            fr.Show();
        }
    }
}
