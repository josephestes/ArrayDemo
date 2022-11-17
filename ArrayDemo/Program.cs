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
            int index;
            int userInput = 0;

            do //run loop once, then check for sentinel value
            {
                switch (userInput) //run code according to user input
                {
                    case 1: //Display array in original order
                        Write("View list in original order:");
                        for (index = 0; index < numbers.Length; ++index)
                            Write("{0,4}", numbers[index]);
                        WriteLine("\n");
                        break;
                    case 2: //Display array in reverse order
                        Write("View list in reverse order:");
                        for (index = (numbers.Length - 1); index >= 0; --index)
                            Write("{0,4}", numbers[index]);
                        WriteLine("\n");
                        break;
                    case 3: //Prompt user for a position and output result
                        do
                        {
                            WriteLine("Enter a position number to view (1 through {0}): \n", numbers.Length);
                            int.TryParse(ReadLine(), out userInput);
                        } while (userInput <= 0 || userInput > numbers.Length);
                        WriteLine("The value at position {0} is {1}\n", userInput, numbers[userInput - 1]);
                        break;
                }

                //Prompt user for array display option
                WriteLine("Please enter one of the following options:\n" +
                    "(1) to view the list in original order.\n" +
                    "(2) to view the list in reverse order.\n" +
                    "(3) to choose a specific position to view.\n" +
                    "(4) to quit the application.\n");

                //Convert input to integer
                int.TryParse(ReadLine(), out userInput);

            } while (userInput != EXIT); //Continue looping until user enters sentinel value
        }
    }
}
