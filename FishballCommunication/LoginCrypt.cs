using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FishballCommunication
{
    class LoginCrypt
    {
        public static string GetMd5(string plainStr)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes_md5_in = Encoding.UTF8.GetBytes(plainStr);
            byte[] bytes_md5_out = md5.ComputeHash(bytes_md5_in);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes_md5_out)
            {
                sb.Append(b.ToString("x2").ToUpper());
            }
            return sb.ToString();
        }
    }
}
