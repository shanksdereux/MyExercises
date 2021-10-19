using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse string without using any built-in function

            Console.WriteLine("Enter a string: ");
            string originalString = Console.ReadLine();

            StringBuilder reverseWordString = new StringBuilder();
            List<char> charList = new List<char>();

            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == ' ' || i == originalString.Length - 1)
                {
                    if (i == originalString.Length - 1)
                    
                        charList.Add(originalString[i]);
                        for (int j = charList.Count - 1; j >= 0; j--)
                        {
                            reverseWordString.Append(charList[j]);
                        }
                        reverseWordString.Append(' ');
                        charList = new List<char>();                
                }
                else
                {
                    charList.Add(originalString[i]);
                }
            }
            Console.WriteLine($"Reverse Word String: {reverseWordString.ToString()}");
            Console.ReadKey();
        }
    }
}


/*private static string ReverseString(string origString)
{
    string reverseString = "";
    int origStringLength = origString.Length - 1;

    while (origStringLength >= 0)
    {
        reverseString = reverseString + origString[origStringLength];
        origStringLength--;
    }
    return reverseString;
}*/
