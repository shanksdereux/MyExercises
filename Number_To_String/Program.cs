using System;

namespace Number_To_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 123;
            Console.WriteLine(NumberToString(num));

            Console.ReadKey();
        }
        public static string NumberToString(int num)
        {
            string nToS = "";
            nToS = num.ToString();

            return new string(nToS);
        }
    }
}
