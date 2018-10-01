using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EasySurvey
{
    public static class SHA256
    {
        private static string SUPER_SECRET_SALT = "your super secret salt goes here";

        public static string Hash(string password)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();

            byte[] input = Encoding.UTF8.GetBytes(SUPER_SECRET_SALT + password);
            byte[] crypto = crypt.ComputeHash(input);

            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }

            return hash.ToString();
        }
    }
}
