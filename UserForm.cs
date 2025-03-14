using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserHash
{
    public partial class UserForm : Form
    {
        private User user;
        private UserManager userManager;

        public UserForm(User user, UserManager userManager)
        {
            InitializeComponent();
            this.user = user;
            this.userManager = userManager;
            lblWelcome.Text = $"Vítej, {user.Username}!";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Heslo nemůže být prázdné.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userManager.ChangePassword(user, newPassword);
            MessageBox.Show("Heslo bylo úspěšně změněno.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
