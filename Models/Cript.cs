using System;
using System.Security.Criptography;
using System.text;

namespace Biblioteca.Models
{
    public class Cript
    {
        public static string textoCript(string textoEntrada){
            MD5 cr = MD5.Create();

            byte[] By = Encoding.Default.GetBytes(textoEntrada);
            byte[] byteCript = cr.ComputeHash(By);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in byteCript)
            {
                string back = b.ToString("x2");
                SB.Append(back);
            }

            return SB.ToString();
        }
    }
}