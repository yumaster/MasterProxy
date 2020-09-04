namespace MasterProxyWinform
{
    partial class Login
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
            this.tbxUser = new MasterProxyWinform.Util.TextBoxEx();
            this.tbxPassword = new MasterProxyWinform.Util.TextBoxEx();
            this.cbxIsAnonymous = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(27, 24);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.PlaceHolderStr = "用户名";
            this.tbxUser.Size = new System.Drawing.Size(140, 21);
            this.tbxUser.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(27, 55);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.PlaceHolderStr = "密码";
            this.tbxPassword.Size = new System.Drawing.Size(140, 21);
            this.tbxPassword.TabIndex = 1;
            // 
            // cbxIsAnonymous
            // 
            this.cbxIsAnonymous.AutoSize = true;
            this.cbxIsAnonymous.Location = new System.Drawing.Point(27, 82);
            this.cbxIsAnonymous.Name = "cbxIsAnonymous";
            this.cbxIsAnonymous.Size = new System.Drawing.Size(72, 16);
            this.cbxIsAnonymous.TabIndex = 11;
            this.cbxIsAnonymous.Text = "匿名登录";
            this.cbxIsAnonymous.UseVisualStyleBackColor = true;
            this.cbxIsAnonymous.CheckedChanged += new System.EventHandler(this.cbxIsAnonymous_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(64, 104);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 139);
            this.Controls.Add(this.cbxIsAnonymous);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "登录";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Util.TextBoxEx tbxUser;
        private Util.TextBoxEx tbxPassword;
        private System.Windows.Forms.CheckBox cbxIsAnonymous;
        private System.Windows.Forms.Button btnLogin;
    }
}