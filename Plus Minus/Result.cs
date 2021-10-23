using System;
using System.Collections.Generic;
using System.Text;

namespace Plus_Minus
{
    class Result
    {
        public static void plusMinus(List<int> arr)
        {

            float positive = 0, negative = 0, zero = 0;
            int number = 0, sizeOfArray = 6;

            Random random = new Random();

            arr.Add(-4);
            arr.Add(3);
            arr.Add(-9);
            arr.Add(0);
            arr.Add(4);
            arr.Add(1);

            foreach (var item in arr)
            {
                if (item < 0)
                {
                    negative++;
                }
                else if (item > 0)
                {
                    positive++;
                }
                else
                {
                    zero++;
                }
            }

            float resultPositive = positive / sizeOfArray;
            float resultNegative = negative / sizeOfArray;
            float resultZero = zero / sizeOfArray;

            Console.WriteLine(resultPositive.ToString("0.000000"));
            Console.WriteLine(resultNegative.ToString("0.000000"));
            Console.WriteLine(resultZero.ToString("0.000000"));
        }
    }
}
