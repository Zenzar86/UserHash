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
    public partial class AdminForm : Form
    {
        private UserManager userManager;

        public AdminForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            LoadUsers();
        }

        private void LoadUsers()
        {
            lstUsers.DataSource = userManager.Users.Select(u => u.Username).ToList();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem != null)
            {
                string username = lstUsers.SelectedItem.ToString();
                string newPassword = txtNewPassword.Text;

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Nové heslo nemůže být prázdné.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                userManager.ResetPassword(username, newPassword);
                MessageBox.Show($"Heslo pro {username} bylo resetováno.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vyberte uživatele.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtNewUsername_Enter(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == "Jméno uživatele")
            {
                txtNewUsername.Text = "";
                txtNewUsername.ForeColor = Color.Black;
            }
        }
        private void txtNewUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUsername.Text))
            {
                txtNewUsername.Text = "Jméno uživatele";
                txtNewUsername.ForeColor = Color.Gray;
            }
        }
        private void txtNewUserPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewUserPassword.Text == "Heslo")
            {
                txtNewUserPassword.Text = "";
                txtNewUserPassword.ForeColor = Color.Black;
            }
        }
        private void txtNewUserPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUserPassword.Text))
            {
                txtNewUserPassword.Text = "Heslo";
                txtNewUserPassword.ForeColor = Color.Gray;
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;
            string password = txtNewUserPassword.Text;
            bool isAdmin = chkIsAdmin.Checked;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vyplňte jméno a heslo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            userManager.AddUser(username, password, isAdmin);
            LoadUsers(); // Aktualizace seznamu uživatelů
        }
    }
}
