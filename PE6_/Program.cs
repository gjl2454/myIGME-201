// See https://aka.ms/new-console-template for more information

using System;

namespace PE6
{
    // Class Program
    // Author: Grace Ledford 
    // Purpose: Parsing and Formatting
    // Restrictions: None
    static class Program
    {
        // Method: Main
        // Purpose: Create a number guessing game, by generating a random integer number between 0 and 100 (inclusive) and a player will try to guess it. 
        // Restrictions: None
        static void Main(string[] args)
        {
            string stringNumber;
            Random rand = new Random();
            // generates a random number between 0 inclusive and 101 exclusive.
            int randomNumber = rand.Next(0, 101);
            // prints the random number.
            Console.WriteLine(randomNumber);

            int i;
            // a loop is used to give the user 8 tries to guess a number.
            for (i = 0; i < 8; ++i)
            {
                Console.WriteLine("Guess a number(should be 0-100): ");

                stringNumber = Console.ReadLine();
                int numberGuessed;
                // parses the value the user enters and checks if their input is valid. 
                if (int.TryParse(stringNumber, out numberGuessed) == false)
                {
                    i--;
                    // goes back to the for loop.
                    continue;
                }
                if (numberGuessed < 0 || numberGuessed > 100)
                {
                    i--;
                    continue;
                }
                if (numberGuessed < randomNumber)
                {
                    // tells user if their guess was correct (high or low).
                    Console.WriteLine("Number is too low!");
                }
                else if (numberGuessed > randomNumber)
                {
                    Console.WriteLine("Number is too high!");
                }
                else
                {
                    // if the correct number is guessed before the 8 turns are up, the user is told how many turns it took to end the loop.
                    Console.WriteLine($"It took you {i + 1} tries to get the number correct!");
                    break;
                }
            }
            // checks to see if user ran out of guesses and tells them what it was.
            if (i == 8)
            {
                Console.WriteLine("Ran out of guesses! The correct number was: " + randomNumber);
            }

        }
    }
}