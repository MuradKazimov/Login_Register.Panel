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
    public partial class CaptchaForm : Form
    {
        public CaptchaForm()
        {
            InitializeComponent();
            LblCaptcha.Text = getCaptcha();
        }
        Random random = new Random();
        

        private void CaptchaButton_Click(object sender, EventArgs e)
        {
            if (LblCaptcha.Text == TxtCaptcha.Text)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblCaptcha.Text = "";
                LblCaptcha.Text = getCaptcha();

            }
        }
        internal string getCaptcha()
        {
            string captcha = "";
            for (int i = 0; i < random.Next(6, 10); i++)
            {
                if (random.Next(2) % 2 == 0)
                {
                    captcha += char.ConvertFromUtf32(random.Next(65, 91));
                    continue;
                }
                captcha += char.ConvertFromUtf32(random.Next(48, 58));
            }
            return captcha;
        }

        private void RefreshCaptcha_Click(object sender, EventArgs e)
        {
            LblCaptcha.Text = getCaptcha();
        }
    }
}
