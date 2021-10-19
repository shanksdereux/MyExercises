using System;

namespace StringtoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringToNumber("2"));
            Console.ReadKey();
        }
        public static int StringToNumber(string str)
        {
            int num = Int32.Parse(str);
            return num;

        }
    }
}
