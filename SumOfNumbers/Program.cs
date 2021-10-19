using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNumber(1, 2));
            Console.ReadKey();
        }
        public static int SumOfNumber(int a, int b)
        {
            int sum = a + b;
            if (a == b)
            {
                return a;
            }
            return sum;
        }
    }
}
