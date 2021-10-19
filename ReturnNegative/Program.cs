using System;

namespace ReturnNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeNegative(0));
            Console.ReadKey();
        }   
        public static int MakeNegative(int number)
        {
            if (number < 0)
            {
                return number;
            }
            else 
            {
                int x = number * -1;
                return x;
            }
        }
    }
}
