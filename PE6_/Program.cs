// See https://aka.ms/new-console-template for more information

using System;

namespace PE6
{
    // Class Program
    // Author: Grace Ledford 
    // Purpose: Parsing and Formatting
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: 
        // Restrictions: None
        static void Main(string[] args)
        {
            string stringNumber;
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine(randomNumber);

            int i;
            for (i = 0; i < 8; ++i)    
            {
                Console.WriteLine("Guess a number(should be 0-100): " );

                stringNumber = Console.ReadLine();
                int numberGuessed;
                if(int.TryParse(stringNumber, out numberGuessed) == false)
                {
                    // goes back to the for loop.
                    i--;
                    continue;
                }
                if(numberGuessed < 0 || numberGuessed > 100)
                {
                    i--;
                    continue;
                }
                if(numberGuessed < randomNumber)
                {
                    Console.WriteLine("Number is too low!");
                } else if (numberGuessed > randomNumber)
                {
                    Console.WriteLine("Number is too high!");
                }
                else 
                {
                    Console.WriteLine($"It took you {i +1} tries to get the number correct!");
                    break;
                }



            }
          // checks to see if we ran out of guesses.
            if(i == 8)
            {
                Console.WriteLine("Ran out of guesses! The correct number was: " + randomNumber);
            }

    }
    }
}