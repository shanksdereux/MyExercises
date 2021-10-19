using System;
using System.Text;

namespace Break_camelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "camelCase";
            Console.WriteLine(BreakCamelCase(test));
            Console.ReadKey();
        }

        private static string BreakCamelCase(string myString)
        {
            string result = string.Empty;

            foreach (char characterInString in myString)
            {
                if (char.IsUpper(characterInString))
                {
                    result = new string(string.Concat(result, " ", characterInString.ToString()).ToCharArray());
                }
                else
                {
                    result = new string(string.Concat(result, characterInString.ToString()).ToCharArray());
                }
            }
            return result;
        }
    }
}
