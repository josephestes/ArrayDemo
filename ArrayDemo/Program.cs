/* 
 * This program stores an array of integers and displays the array based on user input.
 * 
 * User chooses an option and the program fulfils it.
 * 
 * Program loops until the sentinel value is entered
 */

using System;
using static System.Console;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int EXIT = 4;
            int[] numbers = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
            int userInput = 0;

            do // run loop once, then check for sentinel value
            {
                switch (userInput) // run code according to user input
                {
                    case 1: // Display array in original order
                        WriteLine("View list in original order:");
                        foreach (int number in numbers)
                        {
                            Write($"{number,4}");
                        }
                        WriteLine();
                        break;

                    case 2: // Display array in reverse order
                        WriteLine("View list in reverse order:");
                        for (int i = numbers.Length - 1; i >= 0; i--)
                        {
                            Write($"{numbers[i],4}");
                        }
                        WriteLine();
                        break;

                    case 3: // Prompt user for a position and output result
                        WriteLine("Enter a position number to view (1 through {0}): \n", numbers.Length);
                        int position = int.Parse(ReadLine());

                        if (position < 1 || position > numbers.Length)
                        {
                            continue;
                        }

                        WriteLine("The value at position {0} is {1}\n", position, numbers[position - 1]);
                        break;
                }

                // Prompt user for array display option
                WriteLine("Please enter one of the following options:\n" +
                    "(1) to view the list in original order.\n" +
                    "(2) to view the list in reverse order.\n" +
                    "(3) to choose a specific position to view.\n" +
                    "(4) to quit the application.\n");

                // Convert input to integer
                userInput = int.Parse(ReadLine());

            } while (userInput != EXIT); // Continue looping until user enters sentinel value
        }
    }
}
