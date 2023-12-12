using System.Security.Cryptography;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BCryptNet = BCrypt.Net.BCrypt;

namespace DeskInc.Auth
{
    public class PasswordHarsh
    {

        public string HarshPassword(string password)
        {
            return BCryptNet.HashPassword(password);
        }

       
    }
}

/*namespace DeskInc.Auth
{
    public class PasswordHarsh
    {
        public string _password;

        public PasswordHarsh(string password)
        {
            _password = password;
        }

        public string HarshPassword()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(_password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                StringBuilder builder = new StringBuilder();
                  for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool ValidatePassword(string storedHashedPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(_password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                string hashedPassword = builder.ToString();

                return string.Equals(hashedPassword, storedHashedPassword, StringComparison.OrdinalIgnoreCase);
            }
        }

    }
}*/
