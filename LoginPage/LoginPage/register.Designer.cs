namespace LoginPage
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.RegisterButton = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtConfrmPassword = new System.Windows.Forms.TextBox();
            this.ChckBxShowPass = new System.Windows.Forms.CheckBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelTxt = new System.Windows.Forms.Label();
            this.LblUsr = new System.Windows.Forms.Label();
            this.lblPss = new System.Windows.Forms.Label();
            this.LblPssConf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.BackgroundImage")));
            this.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisterButton.Location = new System.Drawing.Point(586, 422);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(171, 37);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.Location = new System.Drawing.Point(598, 308);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(168, 19);
            this.TxtPassword.TabIndex = 11;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.White;
            this.TxtUsername.Location = new System.Drawing.Point(598, 252);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(168, 20);
            this.TxtUsername.TabIndex = 10;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // TxtConfrmPassword
            // 
            this.TxtConfrmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.TxtConfrmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtConfrmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfrmPassword.ForeColor = System.Drawing.Color.White;
            this.TxtConfrmPassword.Location = new System.Drawing.Point(598, 365);
            this.TxtConfrmPassword.Multiline = true;
            this.TxtConfrmPassword.Name = "TxtConfrmPassword";
            this.TxtConfrmPassword.PasswordChar = '*';
            this.TxtConfrmPassword.Size = new System.Drawing.Size(168, 19);
            this.TxtConfrmPassword.TabIndex = 12;
            this.TxtConfrmPassword.TextChanged += new System.EventHandler(this.TxtConfrmPassword_TextChanged);
            // 
            // ChckBxShowPass
            // 
            this.ChckBxShowPass.AutoSize = true;
            this.ChckBxShowPass.BackColor = System.Drawing.Color.White;
            this.ChckBxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChckBxShowPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChckBxShowPass.ForeColor = System.Drawing.Color.Gray;
            this.ChckBxShowPass.Location = new System.Drawing.Point(665, 391);
            this.ChckBxShowPass.Name = "ChckBxShowPass";
            this.ChckBxShowPass.Size = new System.Drawing.Size(104, 17);
            this.ChckBxShowPass.TabIndex = 13;
            this.ChckBxShowPass.Text = "Show Password";
            this.ChckBxShowPass.UseVisualStyleBackColor = false;
            this.ChckBxShowPass.CheckedChanged += new System.EventHandler(this.ChckBxShowPass_CheckedChanged);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.White;
            this.LabelLogin.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(32)))), ((int)(((byte)(137)))));
            this.LabelLogin.Location = new System.Drawing.Point(734, 475);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(53, 21);
            this.LabelLogin.TabIndex = 15;
            this.LabelLogin.Text = "Login";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click_1);
            // 
            // LabelTxt
            // 
            this.LabelTxt.AutoSize = true;
            this.LabelTxt.BackColor = System.Drawing.Color.White;
            this.LabelTxt.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTxt.ForeColor = System.Drawing.Color.Gray;
            this.LabelTxt.Location = new System.Drawing.Point(565, 478);
            this.LabelTxt.Name = "LabelTxt";
            this.LabelTxt.Size = new System.Drawing.Size(174, 17);
            this.LabelTxt.TabIndex = 14;
            this.LabelTxt.Text = "Alderdy have an account?";
            // 
            // LblUsr
            // 
            this.LblUsr.AutoSize = true;
            this.LblUsr.BackColor = System.Drawing.Color.White;
            this.LblUsr.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsr.ForeColor = System.Drawing.Color.Gray;
            this.LblUsr.Location = new System.Drawing.Point(578, 227);
            this.LblUsr.Name = "LblUsr";
            this.LblUsr.Size = new System.Drawing.Size(74, 17);
            this.LblUsr.TabIndex = 16;
            this.LblUsr.Text = "Username";
            // 
            // lblPss
            // 
            this.lblPss.AutoSize = true;
            this.lblPss.BackColor = System.Drawing.Color.White;
            this.lblPss.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPss.ForeColor = System.Drawing.Color.Gray;
            this.lblPss.Location = new System.Drawing.Point(578, 283);
            this.lblPss.Name = "lblPss";
            this.lblPss.Size = new System.Drawing.Size(71, 17);
            this.lblPss.TabIndex = 17;
            this.lblPss.Text = "Password";
            // 
            // LblPssConf
            // 
            this.LblPssConf.AutoSize = true;
            this.LblPssConf.BackColor = System.Drawing.Color.White;
            this.LblPssConf.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPssConf.ForeColor = System.Drawing.Color.Gray;
            this.LblPssConf.Location = new System.Drawing.Point(578, 338);
            this.LblPssConf.Name = "LblPssConf";
            this.LblPssConf.Size = new System.Drawing.Size(126, 17);
            this.LblPssConf.TabIndex = 18;
            this.LblPssConf.Text = "Confirm Password";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.LblPssConf);
            this.Controls.Add(this.lblPss);
            this.Controls.Add(this.LblUsr);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelTxt);
            this.Controls.Add(this.ChckBxShowPass);
            this.Controls.Add(this.TxtConfrmPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.RegisterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtConfrmPassword;
        private System.Windows.Forms.CheckBox ChckBxShowPass;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelTxt;
        private System.Windows.Forms.Label LblUsr;
        private System.Windows.Forms.Label lblPss;
        private System.Windows.Forms.Label LblPssConf;
    }
}