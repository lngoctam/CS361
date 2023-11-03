
namespace PasswordManager
{
    partial class ResetPasswordForm
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
            this.btn_Next = new System.Windows.Forms.Button();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_ResetPassword = new System.Windows.Forms.Label();
            this.lb_AppName = new System.Windows.Forms.Label();
            this.email_verification = new System.Windows.Forms.Label();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(147, 221);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 24);
            this.btn_Next.TabIndex = 10;
            this.btn_Next.Text = "Reset";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(107, 171);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(217, 20);
            this.tb_Email.TabIndex = 9;
            this.tb_Email.Leave += new System.EventHandler(this.tb_Email_Leave);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(59, 174);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 8;
            this.lb_Email.Text = "Email";
            // 
            // lb_ResetPassword
            // 
            this.lb_ResetPassword.AutoSize = true;
            this.lb_ResetPassword.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ResetPassword.Location = new System.Drawing.Point(132, 115);
            this.lb_ResetPassword.Name = "lb_ResetPassword";
            this.lb_ResetPassword.Size = new System.Drawing.Size(126, 19);
            this.lb_ResetPassword.TabIndex = 7;
            this.lb_ResetPassword.Text = "Reset Password";
            // 
            // lb_AppName
            // 
            this.lb_AppName.AutoSize = true;
            this.lb_AppName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppName.Location = new System.Drawing.Point(91, 78);
            this.lb_AppName.Name = "lb_AppName";
            this.lb_AppName.Size = new System.Drawing.Size(233, 26);
            this.lb_AppName.TabIndex = 6;
            this.lb_AppName.Text = "PASSWORD MANAGER";
            // 
            // email_verification
            // 
            this.email_verification.AutoSize = true;
            this.email_verification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_verification.ForeColor = System.Drawing.Color.Red;
            this.email_verification.Location = new System.Drawing.Point(104, 195);
            this.email_verification.Name = "email_verification";
            this.email_verification.Size = new System.Drawing.Size(0, 13);
            this.email_verification.TabIndex = 11;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Location = new System.Drawing.Point(147, 251);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(92, 24);
            this.btn_CreateAccount.TabIndex = 12;
            this.btn_CreateAccount.Text = "Create Account";
            this.btn_CreateAccount.UseVisualStyleBackColor = true;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 381);
            this.Controls.Add(this.btn_CreateAccount);
            this.Controls.Add(this.email_verification);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_ResetPassword);
            this.Controls.Add(this.lb_AppName);
            this.Name = "ResetPasswordForm";
            this.Text = "ResetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_ResetPassword;
        private System.Windows.Forms.Label lb_AppName;
        private System.Windows.Forms.Label email_verification;
        private System.Windows.Forms.Button btn_CreateAccount;
    }
}