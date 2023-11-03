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

namespace PasswordManager
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void tb_Email_Leave(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            if (ExtraFunctions.Email_Verification(emailInput) == false)
            {
                email_verification.Text = "Email does not exist. Please enter another one!";
            }
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            var createForm = new RegisterForm();
            createForm.ShowDialog();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            string emailInput = tb_Email.Text;
            if (ExtraFunctions.Email_Verification(emailInput) == true)
            {
                email_verification.Text = "Temporary password was sent to your email.";
            }
        }
    }
}
