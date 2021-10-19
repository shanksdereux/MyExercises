using System;
using System.Linq;

namespace ReverseStringUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string originalString = Console.ReadLine();

            string reverseWordString = string.Join(" ", originalString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine($"Reverse Word String: {reverseWordString}");
            Console.ReadKey();
        }
    }
}
