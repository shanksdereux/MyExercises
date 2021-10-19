using System;

namespace Is_result_the_same
{
    class Program
    {/*Question: Is result the same
Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.

Expected input and output
IsResultTheSame(2+2, 2*2) → true
IsResultTheSame(9/3, 16-1) → false*/
        public static bool SameOrNot(double x, double y)
        {
            return x == y;
        }
        static void Main(string[] args)
        {
            int[] num = new int[2];
            string operation = "";
            double sum, difference, product, quotient;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Choose 2 operation: Addition = A Subtraction = S Multiplication = M Division = D: ");
                operation = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter 2 number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (operation.ToUpper() == "A" || operation.ToUpper() == "S")
            {
                sum = num[0] + num[1];
                difference = num[0] - num[1];
                    
                Console.WriteLine(SameOrNot(sum, difference));
                Console.ReadLine();
            }
            //Console.ReadLine();
        }
    }
}
