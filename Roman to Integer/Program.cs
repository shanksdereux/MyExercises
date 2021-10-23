using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Roman_to_Integer
{
    class Program
    {

        static void Main(string[] args)
        {        
            int test = RomanToInt("IV");
            Console.WriteLine(test);
            Console.ReadKey();
        }

        public static int RomanToInt(string s)
        {
     
            Dictionary<char, int> roman = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
            int finalRes = 0;
            char lastDigit = default;
            foreach (char c in s)
            {
                roman.TryGetValue(c, out int resCurrent);
                roman.TryGetValue(lastDigit, out int resBefore);
                if (resBefore < resCurrent)
                    finalRes += resCurrent - (resBefore * 2);
                else
                    finalRes += resCurrent;
                lastDigit = c;
            }
            return finalRes;
        }
    }
}
