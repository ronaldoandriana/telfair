using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace Telfair.Services
{
    class Encryption
    {
        public string Encrypt(string pass)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();

            }
                
        }



    }
}
