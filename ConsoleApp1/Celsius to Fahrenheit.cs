using System;

namespace ConsoleApp1
{
    class Program
    {
        public static string CtoF(double celsius)
        {
            double fahrenheit;
            if (celsius < -273.15)
            {
                return "Temperature is below absolute zero.";
            }
            fahrenheit = (celsius * 1.8) + 32;
            return $"T = {fahrenheit}F";
        }
        static void Main(string[] args)
        {            
            double celsius;
            bool c = true;
            string ch = "";
            do
            {
                Console.WriteLine("Enter Celsius: ");
                celsius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(CtoF(celsius));

                Console.WriteLine("Do you want to continue? Y/N: ");
                ch = Console.ReadLine();                
            }while (ch.ToUpper()== "Y"); 
        }
    }
}

