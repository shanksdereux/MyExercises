using System;

namespace BoolToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BoolToWord(false));
            Console.ReadKey();
        }
        public static string BoolToWord(bool word)
        {
            string Nw = "";
            if (word == true)
            {
                return Nw = "Yes";
            }
            else
            {
                return Nw = "No";
            }
        }
    }
}
