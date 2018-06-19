using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Home.Class
{
    public class fungsiHashing
    {
        //Fungsi hashing
        public string hashing(string input)
        {
            //Input adalah password yang akan di hash
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(input, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            //return password hash untuk disimpan di database
            return savedPasswordHash;
        }


        //Fungsi membandingkan password yang diinput dan yang disimpan.
        public bool checkHash(string hashedPassword, string passwordToCompare)
        {
            //hashedPassword dibaca dari database
            //passwordToCompare dibaca dari masukan password user
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(passwordToCompare, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            bool match = true;
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    match = false;
                    break;
                }
            }
            //Return apakah password yang di input dan disimpan di database sama atau tidak
            return match;
        }
    }
}
