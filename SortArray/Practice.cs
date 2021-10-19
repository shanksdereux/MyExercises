using System;
using System.Collections.Generic;
using System.Text;

namespace SortArray
{
    class Practice
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5] { 4, 5, 2, 1, 3 };
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length-1; sort++)
                {
                    if (arr[sort] < arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
          
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
            Console.ReadKey();
        }
    }
}

