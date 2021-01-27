using System;
using System.Security.Cryptography;
using System.Text;

namespace _3_Lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку, которую хотите захешировать: ");
            string source = Console.ReadLine();

            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, source);

                Console.WriteLine($"The SHA256 hash of {source} is: {hash}.");
            }

        }
        public static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
