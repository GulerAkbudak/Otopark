using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data.Helper
{
   public static class CryptHelper
    {
        public static string MdBes(string sifre)
        {
            string strSifre = "";

            MD5 md5 = MD5.Create();
            byte[] hashedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(sifre));

            for (int i = 0; i < hashedBytes.Length; i++)
            {
                strSifre += hashedBytes[i].ToString("x");
            }

            return strSifre;

        }

    }
}
