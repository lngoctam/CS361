using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace PasswordManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void tb_Email_Leave(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            if (ExtraFunctions.Email_Verification(emailInput) == false)
            {
                email_verification.Text = "Email is not correct. Try another email or register for a new one!";
                password_verification.Text = "";
            }
            else
            {
                email_verification.Text = "";
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            string passwordInput = tb_Password.Text;
            if (ExtraFunctions.Email_Verification(emailInput) == true)
            {
                if (ExtraFunctions.Password_Verification(passwordInput) == false)
                {
                    password_verification.Text = "Password is not correct. Please try again or reset your new password";
                }
                else
                {
                    password_verification.Text = "";
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            string passwordInput = tb_Password.Text;

            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                email_verification.Text = "";
                password_verification.Text = "Please enter both email and password.";
            }
            else
            {
                if (ExtraFunctions.Email_Verification(emailInput) == true && ExtraFunctions.Password_Verification(passwordInput) == true)
                {
                    //password_verification.Text = "Login successfully!";
                    User data = new User()
                    {
                        Email = emailInput,
                        Password = passwordInput
                    };

                    //UserPage data_transfer = new UserPage(data);
                    //data_transfer.Show();

                    var createForm = new UserPage(data);
                    createForm.ShowDialog();
                }
            }
        }
        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            var createForm = new RegisterForm();
            createForm.ShowDialog();
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            var createForm = new ResetPasswordForm();
            createForm.ShowDialog();
        }

        
    }
}
