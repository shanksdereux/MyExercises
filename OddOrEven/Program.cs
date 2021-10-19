using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddOrEven(3));
            Console.ReadKey();
        }
        public static string OddOrEven(int a)
        {
            string dec = "";
            if (a % 2 == 0)
            {
                return dec = "Even";
            }
            else 
            {
                return dec = "Odd";
            }
        }
    }
}
