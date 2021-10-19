using System;

namespace SumOfPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4] {1, -4, 7, 12 };
            Console.WriteLine(theSumOfPositive(num));
        }
        public static int theSumOfPositive(int [] arr) 
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
                else 
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
