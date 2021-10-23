using System;
using System.Collections.Generic;
using System.Linq;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            List<int> listOfIntegers = new List<int>();

            Result result = new Result();
            Result.plusMinus(listOfIntegers);

            Console.ReadKey();
        }


    }
}
