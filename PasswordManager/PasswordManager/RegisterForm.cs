using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PasswordManager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Click_here_Click(object sender, EventArgs e)
        {
            Click_here.Text = "8 characters including 1 uppercase letter, \n1 special character, alphanumeric characters";
        }

        private void tb_Email_Leave(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            if (ExtraFunctions.Email_Validation(emailInput) == false)
            {
                email_validation.Text = "Please enter an valid email address";
                password_validation.Text = "";
                confirm_password_match.Text = "";
            }
            else
            {
                email_validation.Text = "";
                if (ExtraFunctions.Email_Verification(emailInput) == true)                
                {
                    email_validation.Text = "Email has already existed. Please choose another one!";
                    password_validation.Text = "";
                    confirm_password_match.Text = "";
                }
                else
                {
                    email_validation.Text = "";
                }
            }            
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            string passwordInput = tb_Password.Text;
            if (ExtraFunctions.Email_Validation(emailInput) == true && ExtraFunctions.Email_Verification(emailInput) == false)
            {
                if (ExtraFunctions.Password_Validation(passwordInput) == false)
                {
                    password_validation.Text = "Password that does not meet the recommended password policy requirements";
                    confirm_password_match.Text = "";
                }
                else
                {
                    password_validation.Text = "";
                }
            }
            else
            {
                password_validation.Text = "";
                confirm_password_match.Text = "";
            }
        }

        private void tb_PasswordConfirm_Leave(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            string passwordInput = tb_Password.Text;
            string passwordConfirmInput = tb_PasswordConfirm.Text;
            if (ExtraFunctions.Email_Validation(emailInput) == true && ExtraFunctions.Email_Verification(emailInput) == false
                && ExtraFunctions.Password_Validation(passwordInput) == true && passwordInput != passwordConfirmInput)
            {
                confirm_password_match.Text = "Password and Password confirm do not match.";
            }
            else
            {
                confirm_password_match.Text = "";
            }
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            string passwordInput = tb_Password.Text;
            string passwordConfirmInput = tb_PasswordConfirm.Text;


            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput) || string.IsNullOrEmpty(passwordConfirmInput))
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                if (ExtraFunctions.Email_Validation(emailInput) == true && ExtraFunctions.Email_Verification(emailInput) == false 
                    && ExtraFunctions.Password_Validation(passwordInput) && passwordInput == passwordConfirmInput)
                {
                    account_created.Text = "Your account was succesfully created";

                    string pathToJsonFile = Setting.JsonPath;
                    var users = ExtraFunctions.Read_Json_File(pathToJsonFile);
                    User newUser = new User
                    {
                        Email = emailInput,
                        Password = passwordInput,
                        Data = new List<DataEntry>()
                    };
                    users.Add(newUser);
                    var updatedObjects = JsonSerializer.Serialize(users);
                    File.WriteAllText(pathToJsonFile, updatedObjects);
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
