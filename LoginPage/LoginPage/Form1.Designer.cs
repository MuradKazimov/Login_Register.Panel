namespace LoginPage
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.ChckBxShowPass = new System.Windows.Forms.CheckBox();
            this.LabelRegister = new System.Windows.Forms.Label();
            this.LabelTxt = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.CausesValidation = false;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(582, 379);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(171, 37);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.White;
            this.TxtUsername.Location = new System.Drawing.Point(597, 252);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(168, 20);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.Text = "   Username";
            // 
            // ChckBxShowPass
            // 
            this.ChckBxShowPass.AutoSize = true;
            this.ChckBxShowPass.BackColor = System.Drawing.Color.White;
            this.ChckBxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChckBxShowPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChckBxShowPass.ForeColor = System.Drawing.Color.Gray;
            this.ChckBxShowPass.Location = new System.Drawing.Point(661, 342);
            this.ChckBxShowPass.Name = "ChckBxShowPass";
            this.ChckBxShowPass.Size = new System.Drawing.Size(104, 17);
            this.ChckBxShowPass.TabIndex = 5;
            this.ChckBxShowPass.Text = "Show Password";
            this.ChckBxShowPass.UseVisualStyleBackColor = false;
            this.ChckBxShowPass.CheckedChanged += new System.EventHandler(this.ChckBxShowPass_CheckedChanged);
            // 
            // LabelRegister
            // 
            this.LabelRegister.AutoSize = true;
            this.LabelRegister.BackColor = System.Drawing.Color.White;
            this.LabelRegister.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LabelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(32)))), ((int)(((byte)(137)))));
            this.LabelRegister.Location = new System.Drawing.Point(605, 468);
            this.LabelRegister.Name = "LabelRegister";
            this.LabelRegister.Size = new System.Drawing.Size(129, 21);
            this.LabelRegister.TabIndex = 8;
            this.LabelRegister.Text = "Create Account";
            this.LabelRegister.Click += new System.EventHandler(this.LabelRegister_Click);
            // 
            // LabelTxt
            // 
            this.LabelTxt.AutoSize = true;
            this.LabelTxt.BackColor = System.Drawing.Color.White;
            this.LabelTxt.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTxt.ForeColor = System.Drawing.Color.Gray;
            this.LabelTxt.Location = new System.Drawing.Point(590, 443);
            this.LabelTxt.Name = "LabelTxt";
            this.LabelTxt.Size = new System.Drawing.Size(159, 17);
            this.LabelTxt.TabIndex = 7;
            this.LabelTxt.Text = "Don\'t have an account?";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.Location = new System.Drawing.Point(597, 307);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(168, 19);
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.Text = "   Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LabelRegister);
            this.Controls.Add(this.LabelTxt);
            this.Controls.Add(this.ChckBxShowPass);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LoginButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.CheckBox ChckBxShowPass;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LabelRegister;
        private System.Windows.Forms.Label LabelTxt;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}

