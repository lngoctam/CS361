
namespace PasswordManager
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
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_AppName = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.password_verification = new System.Windows.Forms.Label();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.email_verification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Location = new System.Drawing.Point(185, 90);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(56, 22);
            this.lb_Login.TabIndex = 7;
            this.lb_Login.Text = "Login";
            // 
            // lb_AppName
            // 
            this.lb_AppName.AutoSize = true;
            this.lb_AppName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppName.Location = new System.Drawing.Point(107, 54);
            this.lb_AppName.Name = "lb_AppName";
            this.lb_AppName.Size = new System.Drawing.Size(233, 26);
            this.lb_AppName.TabIndex = 6;
            this.lb_AppName.Text = "PASSWORD MANAGER";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(156, 266);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(118, 23);
            this.btn_Login.TabIndex = 15;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(112, 204);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(217, 20);
            this.tb_Password.TabIndex = 14;
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(53, 204);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 13;
            this.lb_Password.Text = "Password";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(112, 153);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(217, 20);
            this.tb_Email.TabIndex = 12;
            this.tb_Email.Leave += new System.EventHandler(this.tb_Email_Leave);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(74, 160);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 11;
            this.lb_Email.Text = "Email";
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.Location = new System.Drawing.Point(156, 295);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(118, 24);
            this.btn_ResetPassword.TabIndex = 16;
            this.btn_ResetPassword.Text = "Reset Password";
            this.btn_ResetPassword.UseVisualStyleBackColor = true;
            this.btn_ResetPassword.Click += new System.EventHandler(this.btn_ResetPassword_Click);
            // 
            // password_verification
            // 
            this.password_verification.AutoSize = true;
            this.password_verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_verification.ForeColor = System.Drawing.Color.Red;
            this.password_verification.Location = new System.Drawing.Point(114, 228);
            this.password_verification.Name = "password_verification";
            this.password_verification.Size = new System.Drawing.Size(0, 13);
            this.password_verification.TabIndex = 17;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Location = new System.Drawing.Point(156, 325);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(118, 24);
            this.btn_CreateAccount.TabIndex = 18;
            this.btn_CreateAccount.Text = "Create Account";
            this.btn_CreateAccount.UseVisualStyleBackColor = true;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // email_verification
            // 
            this.email_verification.AutoSize = true;
            this.email_verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_verification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email_verification.Location = new System.Drawing.Point(109, 176);
            this.email_verification.Name = "email_verification";
            this.email_verification.Size = new System.Drawing.Size(0, 13);
            this.email_verification.TabIndex = 19;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 445);
            this.Controls.Add(this.email_verification);
            this.Controls.Add(this.btn_CreateAccount);
            this.Controls.Add(this.password_verification);
            this.Controls.Add(this.btn_ResetPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.lb_AppName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_AppName;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Button btn_ResetPassword;
        private System.Windows.Forms.Label password_verification;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.Label email_verification;
    }
}