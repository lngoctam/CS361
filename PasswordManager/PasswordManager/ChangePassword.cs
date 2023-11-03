using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class ChangePassword : Form
    {
        private User userData;
        public ChangePassword(User data)
        {
            InitializeComponent();
            userData = data;
        }

        private void tb_OldPassword_Leave(object sender, EventArgs e)
        {
            string passwordInput = userData.Password;
            if (tb_OldPassword.Text != passwordInput)
            {
                lb_OldPassword_Verification.Text = "Your password is not correct.";
                lb_NewPassword_Validation.Text = "";
                lb_ConfirmNewPassword_Validation.Text = "";
            }
            else
            {
                lb_OldPassword_Verification.Text = "";
            }
        }
        private void tb_NewPassword_Leave(object sender, EventArgs e)
        {
            if (tb_OldPassword.Text == userData.Password && ExtraFunctions.Password_Validation(tb_NewPassword.Text) == false)
            {
                //lb_OldPassword_Verification.Text = "";
                lb_NewPassword_Validation.Text = "Password that does not meet the recommended password policy requirements";
                lb_ConfirmNewPassword_Validation.Text = "";
            }
            else
            {
                lb_NewPassword_Validation.Text = "";
            }
        }

        private void tb_ConfirmNewPassword_Leave(object sender, EventArgs e)
        {
            if (tb_OldPassword.Text == userData.Password && ExtraFunctions.Password_Validation(tb_NewPassword.Text) == true &&
                tb_NewPassword.Text != tb_ConfirmNewPassword.Text)
            {
                lb_ConfirmNewPassword_Validation.Text = "New Password and Confirm New Password confirm do not match.";
            }
            else
            {
                lb_ConfirmNewPassword_Validation.Text = "";
            }
        }
        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            var createForm = new ResetPasswordForm();
            createForm.ShowDialog();

        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (tb_OldPassword.Text == userData.Password && ExtraFunctions.Password_Validation(tb_NewPassword.Text) == true &&
                tb_NewPassword.Text == tb_ConfirmNewPassword.Text)
            {
                lb_ConfirmNewPassword_Validation.Text = "Your password has been changed";
            }
            string path = "../../../UserData/users.json";
            var users = ExtraFunctions.Read_Json_File(path);
            foreach (var user in users)
            {
                if (user.Email == userData.Email)
                {
                    user.Password = tb_NewPassword.Text;
                    break;
                }
            }
            var updatedObjects = JsonSerializer.Serialize(users);
            File.WriteAllText(path, updatedObjects);
        }

        
    }
}
