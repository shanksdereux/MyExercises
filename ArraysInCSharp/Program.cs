using System;

namespace ArraysInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an array with size 6
            int[] arr = new int[6];

            //Accessing array values using loop
            //Here it will display the default values
            //as we are not assigning values
            for (int i = 0; i < 6; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            int a = 0;

            //Here we are assigning values to array using for loop
            for (int i = 0; i < 6; i++)
            {
                a += 10;
                arr[i] = a;
            }

            //Accessing array values using foreach loop
            /*This for each loop is specially designed in C# for accessing the values from a collection like an array. When we use a for-each loop for accessing the values of an array or collection, 
             * we only require to hand over the array or collection to the loop which does not require any initialization, condition, or iteration. 
             * The loop itself starts its execution by providing access to each and every element present in the array or collection starting from the first up to the last element in sequential order.*/
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
