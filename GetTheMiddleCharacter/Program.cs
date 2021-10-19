using System;

namespace GetTheMiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("test"));
            Console.ReadLine();
        }
        public static string GetMiddle(string str)
        {

            int i = 1 - str.Length % 2;
            return str.Substring(str.Length / 2 - i, 1+i);
        }
    }
}
