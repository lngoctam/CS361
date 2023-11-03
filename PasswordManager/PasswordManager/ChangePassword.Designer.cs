
namespace PasswordManager
{
    partial class ChangePassword
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
            this.password_verification = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.tb_NewPassword = new System.Windows.Forms.TextBox();
            this.lb_NewPassword = new System.Windows.Forms.Label();
            this.tb_OldPassword = new System.Windows.Forms.TextBox();
            this.lb_OldPassword = new System.Windows.Forms.Label();
            this.lb_ChangePassword = new System.Windows.Forms.Label();
            this.lb_AppName = new System.Windows.Forms.Label();
            this.tb_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lb_confirmNewPasword = new System.Windows.Forms.Label();
            this.lb_OldPassword_Verification = new System.Windows.Forms.Label();
            this.lb_NewPassword_Validation = new System.Windows.Forms.Label();
            this.lb_ConfirmNewPassword_Validation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_verification
            // 
            this.email_verification.AutoSize = true;
            this.email_verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_verification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email_verification.Location = new System.Drawing.Point(103, 183);
            this.email_verification.Name = "email_verification";
            this.email_verification.Size = new System.Drawing.Size(0, 13);
            this.email_verification.TabIndex = 30;
            // 
            // password_verification
            // 
            this.password_verification.AutoSize = true;
            this.password_verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_verification.ForeColor = System.Drawing.Color.Red;
            this.password_verification.Location = new System.Drawing.Point(108, 235);
            this.password_verification.Name = "password_verification";
            this.password_verification.Size = new System.Drawing.Size(0, 13);
            this.password_verification.TabIndex = 28;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(195, 316);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(118, 24);
            this.btn_ChangePassword.TabIndex = 27;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.Location = new System.Drawing.Point(195, 346);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(118, 23);
            this.btn_ResetPassword.TabIndex = 26;
            this.btn_ResetPassword.Text = "Reset Password";
            this.btn_ResetPassword.UseVisualStyleBackColor = true;
            this.btn_ResetPassword.Click += new System.EventHandler(this.btn_ResetPassword_Click);
            // 
            // tb_NewPassword
            // 
            this.tb_NewPassword.Location = new System.Drawing.Point(163, 212);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.Size = new System.Drawing.Size(217, 20);
            this.tb_NewPassword.TabIndex = 33;
            this.tb_NewPassword.Leave += new System.EventHandler(this.tb_NewPassword_Leave);
            // 
            // lb_NewPassword
            // 
            this.lb_NewPassword.AutoSize = true;
            this.lb_NewPassword.Location = new System.Drawing.Point(68, 215);
            this.lb_NewPassword.Name = "lb_NewPassword";
            this.lb_NewPassword.Size = new System.Drawing.Size(78, 13);
            this.lb_NewPassword.TabIndex = 24;
            this.lb_NewPassword.Text = "New Password";
            // 
            // tb_OldPassword
            // 
            this.tb_OldPassword.Location = new System.Drawing.Point(163, 164);
            this.tb_OldPassword.Name = "tb_OldPassword";
            this.tb_OldPassword.Size = new System.Drawing.Size(217, 20);
            this.tb_OldPassword.TabIndex = 23;
            this.tb_OldPassword.Leave += new System.EventHandler(this.tb_OldPassword_Leave);
            // 
            // lb_OldPassword
            // 
            this.lb_OldPassword.AutoSize = true;
            this.lb_OldPassword.Location = new System.Drawing.Point(74, 167);
            this.lb_OldPassword.Name = "lb_OldPassword";
            this.lb_OldPassword.Size = new System.Drawing.Size(72, 13);
            this.lb_OldPassword.TabIndex = 22;
            this.lb_OldPassword.Text = "Old Password";
            // 
            // lb_ChangePassword
            // 
            this.lb_ChangePassword.AutoSize = true;
            this.lb_ChangePassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChangePassword.Location = new System.Drawing.Point(185, 102);
            this.lb_ChangePassword.Name = "lb_ChangePassword";
            this.lb_ChangePassword.Size = new System.Drawing.Size(154, 22);
            this.lb_ChangePassword.TabIndex = 21;
            this.lb_ChangePassword.Text = "Change Password";
            // 
            // lb_AppName
            // 
            this.lb_AppName.AutoSize = true;
            this.lb_AppName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppName.Location = new System.Drawing.Point(158, 62);
            this.lb_AppName.Name = "lb_AppName";
            this.lb_AppName.Size = new System.Drawing.Size(233, 26);
            this.lb_AppName.TabIndex = 20;
            this.lb_AppName.Text = "PASSWORD MANAGER";
            // 
            // tb_ConfirmNewPassword
            // 
            this.tb_ConfirmNewPassword.Location = new System.Drawing.Point(163, 260);
            this.tb_ConfirmNewPassword.Name = "tb_ConfirmNewPassword";
            this.tb_ConfirmNewPassword.Size = new System.Drawing.Size(217, 20);
            this.tb_ConfirmNewPassword.TabIndex = 32;
            this.tb_ConfirmNewPassword.Leave += new System.EventHandler(this.tb_ConfirmNewPassword_Leave);
            // 
            // lb_confirmNewPasword
            // 
            this.lb_confirmNewPasword.AutoSize = true;
            this.lb_confirmNewPasword.Location = new System.Drawing.Point(30, 263);
            this.lb_confirmNewPasword.Name = "lb_confirmNewPasword";
            this.lb_confirmNewPasword.Size = new System.Drawing.Size(116, 13);
            this.lb_confirmNewPasword.TabIndex = 31;
            this.lb_confirmNewPasword.Text = "Confirm New Password";
            // 
            // lb_OldPassword_Verification
            // 
            this.lb_OldPassword_Verification.AutoSize = true;
            this.lb_OldPassword_Verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OldPassword_Verification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_OldPassword_Verification.Location = new System.Drawing.Point(160, 187);
            this.lb_OldPassword_Verification.Name = "lb_OldPassword_Verification";
            this.lb_OldPassword_Verification.Size = new System.Drawing.Size(0, 13);
            this.lb_OldPassword_Verification.TabIndex = 34;
            // 
            // lb_NewPassword_Validation
            // 
            this.lb_NewPassword_Validation.AutoSize = true;
            this.lb_NewPassword_Validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewPassword_Validation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_NewPassword_Validation.Location = new System.Drawing.Point(160, 235);
            this.lb_NewPassword_Validation.Name = "lb_NewPassword_Validation";
            this.lb_NewPassword_Validation.Size = new System.Drawing.Size(0, 13);
            this.lb_NewPassword_Validation.TabIndex = 34;
            // 
            // lb_ConfirmNewPassword_Validation
            // 
            this.lb_ConfirmNewPassword_Validation.AutoSize = true;
            this.lb_ConfirmNewPassword_Validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConfirmNewPassword_Validation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_ConfirmNewPassword_Validation.Location = new System.Drawing.Point(160, 283);
            this.lb_ConfirmNewPassword_Validation.Name = "lb_ConfirmNewPassword_Validation";
            this.lb_ConfirmNewPassword_Validation.Size = new System.Drawing.Size(0, 13);
            this.lb_ConfirmNewPassword_Validation.TabIndex = 34;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 447);
            this.Controls.Add(this.lb_ConfirmNewPassword_Validation);
            this.Controls.Add(this.lb_NewPassword_Validation);
            this.Controls.Add(this.lb_OldPassword_Verification);
            this.Controls.Add(this.tb_ConfirmNewPassword);
            this.Controls.Add(this.lb_confirmNewPasword);
            this.Controls.Add(this.email_verification);
            this.Controls.Add(this.password_verification);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.btn_ResetPassword);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.lb_NewPassword);
            this.Controls.Add(this.tb_OldPassword);
            this.Controls.Add(this.lb_OldPassword);
            this.Controls.Add(this.lb_ChangePassword);
            this.Controls.Add(this.lb_AppName);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_verification;
        private System.Windows.Forms.Label password_verification;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_ResetPassword;
        private System.Windows.Forms.TextBox tb_NewPassword;
        private System.Windows.Forms.Label lb_NewPassword;
        private System.Windows.Forms.TextBox tb_OldPassword;
        private System.Windows.Forms.Label lb_OldPassword;
        private System.Windows.Forms.Label lb_ChangePassword;
        private System.Windows.Forms.Label lb_AppName;
        private System.Windows.Forms.TextBox tb_ConfirmNewPassword;
        private System.Windows.Forms.Label lb_confirmNewPasword;
        private System.Windows.Forms.Label lb_OldPassword_Verification;
        private System.Windows.Forms.Label lb_NewPassword_Validation;
        private System.Windows.Forms.Label lb_ConfirmNewPassword_Validation;
    }
}