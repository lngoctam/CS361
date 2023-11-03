
namespace PasswordManager
{
    partial class UserPage
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
            this.email_verification = new System.Windows.Forms.Label();
            this.btn_ViewData = new System.Windows.Forms.Button();
            this.password_verification = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_AppName = new System.Windows.Forms.Label();
            this.lb_userEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_verification
            // 
            this.email_verification.AutoSize = true;
            this.email_verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_verification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email_verification.Location = new System.Drawing.Point(127, 235);
            this.email_verification.Name = "email_verification";
            this.email_verification.Size = new System.Drawing.Size(0, 13);
            this.email_verification.TabIndex = 30;
            // 
            // btn_ViewData
            // 
            this.btn_ViewData.Location = new System.Drawing.Point(83, 273);
            this.btn_ViewData.Name = "btn_ViewData";
            this.btn_ViewData.Size = new System.Drawing.Size(118, 24);
            this.btn_ViewData.TabIndex = 29;
            this.btn_ViewData.Text = "View Data";
            this.btn_ViewData.UseVisualStyleBackColor = true;
            // 
            // password_verification
            // 
            this.password_verification.AutoSize = true;
            this.password_verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_verification.ForeColor = System.Drawing.Color.Red;
            this.password_verification.Location = new System.Drawing.Point(123, 229);
            this.password_verification.Name = "password_verification";
            this.password_verification.Size = new System.Drawing.Size(0, 13);
            this.password_verification.TabIndex = 28;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(83, 235);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(118, 23);
            this.btn_ChangePassword.TabIndex = 26;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(80, 193);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 22;
            this.lb_Email.Text = "Email";
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Location = new System.Drawing.Point(70, 108);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(187, 22);
            this.lb_Login.TabIndex = 21;
            this.lb_Login.Text = "Account Management";
            // 
            // lb_AppName
            // 
            this.lb_AppName.AutoSize = true;
            this.lb_AppName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppName.Location = new System.Drawing.Point(53, 72);
            this.lb_AppName.Name = "lb_AppName";
            this.lb_AppName.Size = new System.Drawing.Size(233, 26);
            this.lb_AppName.TabIndex = 20;
            this.lb_AppName.Text = "PASSWORD MANAGER";
            // 
            // lb_userEmail
            // 
            this.lb_userEmail.AutoSize = true;
            this.lb_userEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userEmail.Location = new System.Drawing.Point(127, 193);
            this.lb_userEmail.Name = "lb_userEmail";
            this.lb_userEmail.Size = new System.Drawing.Size(41, 13);
            this.lb_userEmail.TabIndex = 31;
            this.lb_userEmail.Text = "label1";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 415);
            this.Controls.Add(this.lb_userEmail);
            this.Controls.Add(this.email_verification);
            this.Controls.Add(this.btn_ViewData);
            this.Controls.Add(this.password_verification);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.lb_AppName);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_verification;
        private System.Windows.Forms.Button btn_ViewData;
        private System.Windows.Forms.Label password_verification;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_AppName;
        private System.Windows.Forms.Label lb_userEmail;
    }
}