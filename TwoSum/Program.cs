using System;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theNumbers = new int[2] { 3, 2 };
            Console.WriteLine(TwoSum(theNumbers, 5));
            Console.ReadKey();
        }

        private static int[] TwoSum(int[] numbers, int target)
        {
            //Solution 1
            //foreach (var number in numbers)
            //{
            //    var num = target - number;
            //    if (numbers.Contains(num))
            //    {
            //        var index1 = Array.IndexOf(numbers, num);
            //        var index2 = Array.LastIndexOf(numbers, number);
            //        return new int[] { index1, index2 };
            //    }
            //}
            //return new int[0];

            //Solution 2
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] + numbers[j] == target & i != j)
            //            return new int[] { i, j };
            //    }
            //}

            //return new int[] { };

            //Solution 3
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] { };

            //Test
            //int[] numbers = new int[4] { 1, 2, 3, 4 };
            //var target = 5;
            //int sum = 0, result = 0;


            //Random random = new Random();
            //int length = random.Next(numbers.Length - 1);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum = numbers[i] + numbers[length];
            //    Console.WriteLine(Array.IndexOf(numbers, i));
            //}

        }
    }
}
