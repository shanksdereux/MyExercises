using System;

namespace GreetingFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("nikkie"));
            Console.ReadKey();
        }
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }
    }
}
