using System;

namespace _2DimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine($"Element {i}:" );
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = arr.Length; i >=9; i--)
            {
                Console.Write( arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
