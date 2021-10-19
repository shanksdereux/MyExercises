using System;

namespace SumOfAngles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Angle(4));
            Console.ReadKey();
        }

        private static int Angle(int n)
        {
            return (2 * n - 4) * 90;
        }
    }
}
