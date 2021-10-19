using System;

namespace Duplicate_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "dddd";
            Console.WriteLine(DuplicateEncode(str));

            Console.ReadKey();
        }

        public static string DuplicateEncode(string word)
        {
            char[] array = word.ToCharArray();
            string str = "";

            foreach (char c in word)
            {
                for (int i = 0; i < array.Length; i++)
                {

                    if (array[0] == array[i])
                    {
                        word = ")";
                    }


                    else
                    {
                        word = "(";
                    }
                }
            }


            return new string(str);
        }
    }
}
