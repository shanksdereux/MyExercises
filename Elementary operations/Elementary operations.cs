using System;

namespace Elementary_operations
{
    class Program
    {
        public static string ElementaryOperations(double x, double y)
        {
            double sum, difference, product, quotient;
            sum = x + y;
            difference = x - y;
            product = x * y;
            if (y != 0)
            {
                quotient = x / (double)y;
            }
            else
            {
                quotient = 0;
            }

            return String.Format($"x+y = {sum}, x-y = {difference}, x*y = {product},x/y = {quotient}");
        }
        static void Main(string[] args)
        {
            int[] number = new int[2];
            string ch;
            do
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Enter number: ");
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(ElementaryOperations(number[0], number[1]));

                Console.WriteLine("Do you want to continue? Y/N: ");
                 ch = Console.ReadLine();
            } while (ch.ToUpper() == "Y");
        }
    }
}
