using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UserHash
{
    public class UserManager
    {
        private const string FilePath = "uzivatele.xml";
        public List<User> Users { get; private set; }

        public UserManager()
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                    {
                        Users = (List<User>)serializer.Deserialize(fs);
                    }
                }
                catch
                {
                    Users = new List<User>();
                }
            }
            else
            {
                Users = new List<User>();
                Users.Add(new Admin("admin", "admin")); // Defaultní admin účet
                SaveUsers();
            }
        }

        public void SaveUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                serializer.Serialize(fs, Users);
            }
        }
        public void AddUser(string username, string password, bool isAdmin = false)
        {
            if (Users.Any(u => u.Username == username))
            {
                MessageBox.Show("Uživatel s tímto jménem již existuje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = isAdmin ? new Admin(username, password) : new User(username, password);
            Users.Add(newUser);
            SaveUsers();
            MessageBox.Show($"Uživatel {username} byl úspěšně přidán.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public User Authenticate(string username, string password)
        {
            return Users.FirstOrDefault(u => u.Username == username && u.VerifyPassword(password));
        }

        public void ChangePassword(User user, string newPassword)
        {
            user.ChangePassword(newPassword);
            SaveUsers();
        }

        public void ResetPassword(string username, string newPassword)
        {
            User user = Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                user.ChangePassword(newPassword);
                SaveUsers();
            }
        }
    }
}
