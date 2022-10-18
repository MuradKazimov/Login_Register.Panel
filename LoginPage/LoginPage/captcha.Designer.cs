namespace LoginPage
{
    partial class CaptchaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaForm));
            this.LblCaptcha = new System.Windows.Forms.Label();
            this.TxtCaptcha = new System.Windows.Forms.TextBox();
            this.CaptchaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RefreshCaptcha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCaptcha
            // 
            this.LblCaptcha.AutoSize = true;
            this.LblCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.LblCaptcha.Font = new System.Drawing.Font("Vladimir Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaptcha.Location = new System.Drawing.Point(191, 75);
            this.LblCaptcha.Name = "LblCaptcha";
            this.LblCaptcha.Size = new System.Drawing.Size(0, 39);
            this.LblCaptcha.TabIndex = 0;
            // 
            // TxtCaptcha
            // 
            this.TxtCaptcha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtCaptcha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCaptcha.Location = new System.Drawing.Point(40, 73);
            this.TxtCaptcha.Multiline = true;
            this.TxtCaptcha.Name = "TxtCaptcha";
            this.TxtCaptcha.Size = new System.Drawing.Size(126, 43);
            this.TxtCaptcha.TabIndex = 1;
            this.TxtCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaptchaButton
            // 
            this.CaptchaButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CaptchaButton.FlatAppearance.BorderSize = 0;
            this.CaptchaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaptchaButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptchaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CaptchaButton.Location = new System.Drawing.Point(40, 155);
            this.CaptchaButton.Name = "CaptchaButton";
            this.CaptchaButton.Size = new System.Drawing.Size(126, 54);
            this.CaptchaButton.TabIndex = 2;
            this.CaptchaButton.Text = "VERIFY";
            this.CaptchaButton.UseVisualStyleBackColor = false;
            this.CaptchaButton.Click += new System.EventHandler(this.CaptchaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(385, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RefreshCaptcha
            // 
            this.RefreshCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.RefreshCaptcha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshCaptcha.BackgroundImage")));
            this.RefreshCaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshCaptcha.FlatAppearance.BorderSize = 0;
            this.RefreshCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshCaptcha.Location = new System.Drawing.Point(231, 155);
            this.RefreshCaptcha.Name = "RefreshCaptcha";
            this.RefreshCaptcha.Size = new System.Drawing.Size(50, 50);
            this.RefreshCaptcha.TabIndex = 4;
            this.RefreshCaptcha.UseVisualStyleBackColor = false;
            this.RefreshCaptcha.Click += new System.EventHandler(this.RefreshCaptcha_Click);
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.RefreshCaptcha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CaptchaButton);
            this.Controls.Add(this.TxtCaptcha);
            this.Controls.Add(this.LblCaptcha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CaptchaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCaptcha;
        private System.Windows.Forms.TextBox TxtCaptcha;
        private System.Windows.Forms.Button CaptchaButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RefreshCaptcha;
    }
}