using System;

namespace ReverseStringandFindOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter a string: ");
            input = Console.ReadLine();

            Console.WriteLine(ReverseString(input));
            Console.WriteLine(OccuranceInString(input));

            Console.ReadKey();
        }

        public static string ReverseString(string str)
        {
            string reverseString = string.Empty;

            foreach (char c in str)
            {
                reverseString = c + reverseString;
            }
            return new string(reverseString);
        }

        public static string OccuranceInString(string str)
        {
            while (str.Length > 0)
            {
                Console.Write(str[0] + ":");
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            return str;
        }
    }
}
