using System;

namespace Palindrome_Number
{
    class Program
    {
        private bool IsPalindrome(int x)
        {
            int temp = x;
            int reverseNumber = 0;
            while (x > 0)
            {
                reverseNumber =reverseNumber * 10 + x % 10;
                x /= 10;
            }
         
            if (reverseNumber == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Program connect = new Program();
            bool test = connect.IsPalindrome(303);
            Console.WriteLine(test);
            Console.ReadKey();
        }
    }

}
