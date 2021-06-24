namespace BookStore
{
    partial class SignInForm
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
            this.textLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonWindowsSecurity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(128, 33);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(100, 20);
            this.textLogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(69, 40);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(69, 85);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(128, 82);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 2;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(137, 108);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonWindowsSecurity
            // 
            this.buttonWindowsSecurity.Location = new System.Drawing.Point(72, 147);
            this.buttonWindowsSecurity.Name = "buttonWindowsSecurity";
            this.buttonWindowsSecurity.Size = new System.Drawing.Size(196, 23);
            this.buttonWindowsSecurity.TabIndex = 5;
            this.buttonWindowsSecurity.Text = "Windows Authentication";
            this.buttonWindowsSecurity.UseVisualStyleBackColor = true;
            this.buttonWindowsSecurity.Click += new System.EventHandler(this.buttonWindowsSecurity_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.buttonWindowsSecurity);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textLogin);
            this.MaximumSize = new System.Drawing.Size(360, 280);
            this.MinimumSize = new System.Drawing.Size(360, 280);
            this.Name = "Form5";
            this.Text = "LoginPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonWindowsSecurity;
    }
}