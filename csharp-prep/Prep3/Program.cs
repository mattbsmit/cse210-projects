using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);
        int userGuess;

        do
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            userGuess = int.Parse(guessNumber);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userGuess != magicNumber);
    }
}