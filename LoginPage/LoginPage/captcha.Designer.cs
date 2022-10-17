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
            this.LblCaptcha = new System.Windows.Forms.Label();
            this.TxtCaptcha = new System.Windows.Forms.TextBox();
            this.CaptchaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCaptcha
            // 
            this.LblCaptcha.AutoSize = true;
            this.LblCaptcha.Location = new System.Drawing.Point(119, 57);
            this.LblCaptcha.Name = "LblCaptcha";
            this.LblCaptcha.Size = new System.Drawing.Size(35, 13);
            this.LblCaptcha.TabIndex = 0;
            this.LblCaptcha.Text = "label1";
            // 
            // TxtCaptcha
            // 
            this.TxtCaptcha.Location = new System.Drawing.Point(102, 96);
            this.TxtCaptcha.Name = "TxtCaptcha";
            this.TxtCaptcha.Size = new System.Drawing.Size(75, 20);
            this.TxtCaptcha.TabIndex = 1;
            // 
            // CaptchaButton
            // 
            this.CaptchaButton.Location = new System.Drawing.Point(76, 152);
            this.CaptchaButton.Name = "CaptchaButton";
            this.CaptchaButton.Size = new System.Drawing.Size(101, 56);
            this.CaptchaButton.TabIndex = 2;
            this.CaptchaButton.Text = "button1";
            this.CaptchaButton.UseVisualStyleBackColor = true;
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CaptchaButton);
            this.Controls.Add(this.TxtCaptcha);
            this.Controls.Add(this.LblCaptcha);
            this.Name = "CaptchaForm";
            this.Text = "captcha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCaptcha;
        private System.Windows.Forms.TextBox TxtCaptcha;
        private System.Windows.Forms.Button CaptchaButton;
    }
}