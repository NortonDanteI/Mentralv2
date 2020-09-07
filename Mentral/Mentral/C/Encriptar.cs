using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mentral.C
{
    class Encriptar
    {
        #region metodo para encriptar SHA256
        public static string Encripta(string a)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
            byte[] inputBytes = Encoding.UTF8.GetBytes(a);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < hashedBytes.Length; i++)
            {
                output.Append(hashedBytes[i].ToString("x2").ToLower());
            }
            return (output.ToString());
        }
        #endregion
    }
}
