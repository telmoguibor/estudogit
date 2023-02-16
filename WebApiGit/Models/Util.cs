using System.Security.Cryptography;
using System.Text;

namespace WebApiGit.Models
{
    public static class Util
    {
        /// <summary>
        /// gera um MD5 do texto informado
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GerarMd5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
