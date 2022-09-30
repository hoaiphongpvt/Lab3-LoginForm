namespace LoginForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.ipUserName = new System.Windows.Forms.TextBox();
            this.ipPassword = new System.Windows.Forms.TextBox();
            this.cbAccount = new System.Windows.Forms.CheckBox();
            this.lnRemember = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(233, 77);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(82, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User name:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(233, 144);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 20);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password:";
            // 
            // ipUserName
            // 
            this.ipUserName.Location = new System.Drawing.Point(331, 74);
            this.ipUserName.Name = "ipUserName";
            this.ipUserName.Size = new System.Drawing.Size(199, 27);
            this.ipUserName.TabIndex = 2;
            // 
            // ipPassword
            // 
            this.ipPassword.Location = new System.Drawing.Point(331, 141);
            this.ipPassword.Name = "ipPassword";
            this.ipPassword.Size = new System.Drawing.Size(199, 27);
            this.ipPassword.TabIndex = 3;
            this.ipPassword.PasswordChar= '*';
            // 
            // cbAccount
            // 
            this.cbAccount.AutoSize = true;
            this.cbAccount.Location = new System.Drawing.Point(257, 207);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(18, 17);
            this.cbAccount.TabIndex = 4;
            this.cbAccount.UseVisualStyleBackColor = true;
            // 
            // lnRemember
            // 
            this.lnRemember.AutoSize = true;
            this.lnRemember.Location = new System.Drawing.Point(281, 205);
            this.lnRemember.Name = "lnRemember";
            this.lnRemember.Size = new System.Drawing.Size(172, 20);
            this.lnRemember.TabIndex = 5;
            this.lnRemember.Text = "Remember this account?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(347, 270);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnRemember);
            this.Controls.Add(this.cbAccount);
            this.Controls.Add(this.ipPassword);
            this.Controls.Add(this.ipUserName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbUserName;
        private Label lbPassword;
        private TextBox ipUserName;
        private TextBox ipPassword;
        private CheckBox cbAccount;
        private Label lnRemember;
        private Button btnLogin;
    }
}