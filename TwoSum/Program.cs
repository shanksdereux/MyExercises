using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theNumbers = new int[3] {3,2,4 };
            Console.WriteLine(TwoSum(theNumbers,6));
            Console.ReadKey();
        }

        private static int [] TwoSum (int [] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }
    }
}
