using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisemvowelTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Disemvowel("Hello World!"));
            Console.ReadKey();
        }

        private static string Disemvowel(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            List<char> listOfVowels = vowels.OfType<char>().ToList();

            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < sb.Length; i++)
            {
                if (listOfVowels.Contains(sb[i]))
                {
                    sb.Replace(sb[i].ToString(), "");
                    i--;
                }
            }

            return sb.ToString();
        }
    }
}
