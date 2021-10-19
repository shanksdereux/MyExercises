using System;

namespace FindtheNeedleinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] words = new object[5] {"Yehey", "Hahah", "junk", "needle", "kawai"};

            Console.WriteLine(findTheneedle(words));
            Console.ReadKey();
        }
        public static string findTheneedle(object[] haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i].ToString() != "needle")
                {
                    return "";
                }
                else 
                {
                    Console.WriteLine("found the needle at position " + haystack[i]);
                    break;
                }
            }
            return "";
        }
    }
}
