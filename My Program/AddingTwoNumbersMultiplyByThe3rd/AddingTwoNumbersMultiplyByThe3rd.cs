using System;

namespace My_Program
{
    class AddingTwoNumbersMultiplyByThe3rd
    {
        /* Question: Add two numbers Given three numbers, write a method that adds two first ones and multiplies them by a third one.
           Expected input and output
           AddAndMultiply(2, 4, 5) → 30*/
        public static double AddandMultiply(double x, double y, double z)
        {
            return (x + y) * z;
        }
        static void Main(string[] args)
        {
            //int i;
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter 3 numbers: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(AddandMultiply(arr[0], arr[1], arr[2]));
            Console.ReadLine();
        }
    }
}

