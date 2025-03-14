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
    public partial class LoginForm : Form
    {
        private UserManager userManager;

        public LoginForm()
        {
            InitializeComponent();
            userManager = new UserManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = userManager.Authenticate(username, password);

            if (user != null)
            {
                if (user is Admin)
                {
                    AdminForm adminForm = new AdminForm(userManager);
                    adminForm.Show();
                }
                else
                {
                    UserForm userForm = new UserForm(user, userManager);
                    userForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Neplatné přihlašovací údaje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
