using System;

namespace CountOfPositives_SumOfNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, -1, -2, -3, -4, -5 };

            Console.WriteLine(CountPositivesSumNegatives(numbers));
            Console.ReadKey();
        }
        public static int[] CountPositivesSumNegatives(int[] input)
        {
          
            if (input == null || input.Length == 0 )
            {
                return new int[] { };
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    input[0]++;
                }
                if(input[i] < 0)
                {
                    input[1] += input[i];
                }
            }
            return input;
        }
    }
}
