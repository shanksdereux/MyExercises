using System;

namespace Capitalize_the_First_letter_of_Each_Word_in_a_String
{
    public static class Program
    {
        /*Algorithm:
        1. Create a method/function. That method/function will handle the code to capitalize the first word.
        2. Make sure that the words that the user will input later is in lower case. so make the word lower case first.
        3. After that, convert string to char to manipulate every character in string. Convert string to char (character).
        4. Create a for loop to check if the char in the first word is Capitalize. if not, Make that capitalize.
        5. Create a for loop again to check if the the first word after a "space" is Capitalie.if not, Make that capitalize.
        6. Return the value in new string()
         */
        static string ToJadenCase(this string phrase)
        {
            phrase = phrase.ToLower();//Make the string in lowercase
            char[] array = phrase.ToCharArray();

            if (array.Length >= 1)//If the first character in words is lowercase, Change it to Uppercase
            {

                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)//loop to scan input array
            {

                if (array[i - 1] == ' ')//Make the First letter of the word capitalize(Uppercase) after spaces.
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string str = Console.ReadLine();
            string titleCase = ToJadenCase(str);

            Console.WriteLine("The text: " + titleCase);

            Console.ReadKey();
        }
    }
}
