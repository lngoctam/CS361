using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class UserPage : Form
    {
        private User userData;
        public UserPage(User data)
        {
            InitializeComponent();
            userData = data;
            lb_userEmail.Text = userData.Email;
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            var createForm = new ChangePassword(userData);
            createForm.ShowDialog();
        }
    }
}
