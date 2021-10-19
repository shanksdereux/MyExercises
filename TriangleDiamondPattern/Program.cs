using System;

namespace TriangleDiamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int innerLoop, outerLoop, countOfSpace = 1, numberOfRows;

            Console.Write("Enter number of rows: ");
            numberOfRows = int.Parse(Console.ReadLine());

            countOfSpace = numberOfRows - 1;

            for (outerLoop = 1; outerLoop <= numberOfRows; outerLoop++)
            {
                for (innerLoop = 1; innerLoop <= countOfSpace; innerLoop++)
                    Console.Write(" ");
                countOfSpace--;
                for (innerLoop = 1; innerLoop <= 2 * outerLoop - 1; innerLoop++)
                    Console.Write("*");
                Console.WriteLine();   
            }

            countOfSpace = 1;

            for (outerLoop = 1; outerLoop <= numberOfRows - 1; outerLoop++)
            {
                for (innerLoop = 1; innerLoop <= countOfSpace; innerLoop++)
                    Console.Write(" ");
                countOfSpace++;
                for (innerLoop = 1; innerLoop <= 2 * (numberOfRows - outerLoop) - 1; innerLoop++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
