using System;

namespace anagramCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string oriG = "teluk";
            string test = "kulet";

            Console.WriteLine(anagramChecker(oriG, test));

            Console.ReadKey();
        }
        public static bool anagramChecker(string originalString, string anagram)
        {
            char[] origStr = originalString.ToLower().ToCharArray();
            char[] anaG = anagram.ToLower().ToCharArray();

            Array.Sort(origStr);
            Array.Sort(anaG);
        
            string NewOrig = new string(origStr);
            string NewAnaG = new string(anaG);

            if (NewOrig == NewAnaG)
            {
                Console.WriteLine(NewOrig);
                Console.WriteLine(NewAnaG);
                return true;
            }
            else
            {
                Console.WriteLine(NewOrig);
                return false;
            }

        }
    }
}
