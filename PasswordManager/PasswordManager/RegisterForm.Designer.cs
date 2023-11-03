
namespace PasswordManager
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
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Register = new System.Windows.Forms.Label();
            this.lb_AppName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_ConfirmPassword = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_PasswordConfirm = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Click_here = new System.Windows.Forms.Label();
            this.email_validation = new System.Windows.Forms.Label();
            this.password_validation = new System.Windows.Forms.Label();
            this.confirm_password_match = new System.Windows.Forms.Label();
            this.account_created = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(169, 156);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(217, 20);
            this.tb_Email.TabIndex = 7;
            this.tb_Email.Leave += new System.EventHandler(this.tb_Email_Leave);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(131, 159);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 6;
            this.lb_Email.Text = "Email";
            // 
            // lb_Register
            // 
            this.lb_Register.AutoSize = true;
            this.lb_Register.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Register.Location = new System.Drawing.Point(194, 110);
            this.lb_Register.Name = "lb_Register";
            this.lb_Register.Size = new System.Drawing.Size(133, 22);
            this.lb_Register.TabIndex = 5;
            this.lb_Register.Text = "Create Account";
            // 
            // lb_AppName
            // 
            this.lb_AppName.AutoSize = true;
            this.lb_AppName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppName.Location = new System.Drawing.Point(153, 75);
            this.lb_AppName.Name = "lb_AppName";
            this.lb_AppName.Size = new System.Drawing.Size(233, 26);
            this.lb_AppName.TabIndex = 4;
            this.lb_AppName.Text = "PASSWORD MANAGER";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(110, 207);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 8;
            this.lb_Password.Text = "Password";
            // 
            // lb_ConfirmPassword
            // 
            this.lb_ConfirmPassword.AutoSize = true;
            this.lb_ConfirmPassword.Location = new System.Drawing.Point(47, 262);
            this.lb_ConfirmPassword.Name = "lb_ConfirmPassword";
            this.lb_ConfirmPassword.Size = new System.Drawing.Size(116, 13);
            this.lb_ConfirmPassword.TabIndex = 8;
            this.lb_ConfirmPassword.Text = "Confirm Your Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(169, 207);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(217, 20);
            this.tb_Password.TabIndex = 9;
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // tb_PasswordConfirm
            // 
            this.tb_PasswordConfirm.Location = new System.Drawing.Point(169, 255);
            this.tb_PasswordConfirm.Name = "tb_PasswordConfirm";
            this.tb_PasswordConfirm.Size = new System.Drawing.Size(217, 20);
            this.tb_PasswordConfirm.TabIndex = 9;
            this.tb_PasswordConfirm.Leave += new System.EventHandler(this.tb_PasswordConfirm_Leave);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(213, 329);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(79, 23);
            this.btn_Create.TabIndex = 10;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(213, 358);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(79, 23);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Click_here
            // 
            this.Click_here.AutoSize = true;
            this.Click_here.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click_here.Location = new System.Drawing.Point(167, 297);
            this.Click_here.Name = "Click_here";
            this.Click_here.Size = new System.Drawing.Size(172, 12);
            this.Click_here.TabIndex = 11;
            this.Click_here.Text = "Click here to see password requirements";
            this.Click_here.Click += new System.EventHandler(this.Click_here_Click);
            // 
            // email_validation
            // 
            this.email_validation.AutoSize = true;
            this.email_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_validation.ForeColor = System.Drawing.Color.Red;
            this.email_validation.Location = new System.Drawing.Point(172, 179);
            this.email_validation.Name = "email_validation";
            this.email_validation.Size = new System.Drawing.Size(0, 13);
            this.email_validation.TabIndex = 13;
            // 
            // password_validation
            // 
            this.password_validation.AutoSize = true;
            this.password_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_validation.ForeColor = System.Drawing.Color.Red;
            this.password_validation.Location = new System.Drawing.Point(172, 230);
            this.password_validation.Name = "password_validation";
            this.password_validation.Size = new System.Drawing.Size(0, 13);
            this.password_validation.TabIndex = 15;
            // 
            // confirm_password_match
            // 
            this.confirm_password_match.AutoSize = true;
            this.confirm_password_match.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_match.ForeColor = System.Drawing.Color.Red;
            this.confirm_password_match.Location = new System.Drawing.Point(172, 278);
            this.confirm_password_match.Name = "confirm_password_match";
            this.confirm_password_match.Size = new System.Drawing.Size(0, 13);
            this.confirm_password_match.TabIndex = 16;
            // 
            // account_created
            // 
            this.account_created.AutoSize = true;
            this.account_created.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_created.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.account_created.Location = new System.Drawing.Point(172, 394);
            this.account_created.Name = "account_created";
            this.account_created.Size = new System.Drawing.Size(0, 15);
            this.account_created.TabIndex = 17;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 462);
            this.Controls.Add(this.account_created);
            this.Controls.Add(this.confirm_password_match);
            this.Controls.Add(this.password_validation);
            this.Controls.Add(this.email_validation);
            this.Controls.Add(this.Click_here);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tb_PasswordConfirm);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_ConfirmPassword);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Register);
            this.Controls.Add(this.lb_AppName);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Register;
        private System.Windows.Forms.Label lb_AppName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_ConfirmPassword;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_PasswordConfirm;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label Click_here;
        private System.Windows.Forms.Label email_validation;
        private System.Windows.Forms.Label password_validation;
        private System.Windows.Forms.Label confirm_password_match;
        private System.Windows.Forms.Label account_created;
    }
}