using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace UserHash
{
    [XmlInclude(typeof(Admin))]
    [Serializable]
    public class User
    {
        public string Username { get; set; }
        public string HashedPassword { get; set; }

        public User() { } 

        public User(string username, string password)
        {
            Username = username;
            HashedPassword = HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return HashedPassword == HashPassword(password);
        }

        protected string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public void ChangePassword(string newPassword)
        {
            HashedPassword = HashPassword(newPassword);
        }
    }
}
