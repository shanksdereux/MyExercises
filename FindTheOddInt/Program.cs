using System;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 1, 2, 2, 3,3 };
            Console.WriteLine(find_it(num));
            Console.ReadKey();
        }
        public static int find_it(int [] seq)
        {
            int count = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] == 1 && seq[i] % 2 == 1)
                {
                    count = seq[i];

                }
                else
                {
                    count.ToString("false");
                }
            }
            return count;
           
        }
    }
}
