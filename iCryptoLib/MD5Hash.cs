using System;
using System.Security.Cryptography;
using System.Text;

namespace iCryptoLib
{
    public class MD5Hash
    {
        public string Create(string data)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] bdata = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < bdata.Length; i++)
                {
                    sBuilder.Append(bdata[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
