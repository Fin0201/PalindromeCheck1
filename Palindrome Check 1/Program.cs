using System;

namespace Palindrome_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string"); //Asks the user to enter a string.
            string userString = Console.ReadLine().ToLower(); //Inputs and converts the string to all lowercase so it isn't case sensitive.


            for (int i = 0; i < userString.Length; i++) //Loops the following code for every character in the string.
            {
                if (userString[i] != userString[userString.Length - 1 - i]) //Checks if the cvharacters are not the same.
                {
                    Console.WriteLine($"{userString} is not a palindrome.");
                    break; //Breaks the loop
                }
                else if (i == userString.Length - 1) //Checks if this is the last iteration of the loop
                {
                    Console.WriteLine($"{userString} is a palindrome.");
                }
            }
        }
    }
}