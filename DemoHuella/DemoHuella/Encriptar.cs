using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoHuella
{
    class Encriptar
    {
        public string Encriptado(string Texto)
        {
            string result = string.Empty;
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(Texto);

            byte[] hash = sha256.ComputeHash(bytes);

            result =(BitConverter.ToString(hash).Replace("-", ""));
            return result;
        }
    }
}
