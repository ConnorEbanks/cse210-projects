using System;

class Program
{
    static void Main(string[] args)
    {
        string play = ("yes");

        while (play == "yes")
        {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        int numberOfGuesses = 0;
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                numberOfGuesses +=1;
            }     

            Console.WriteLine($"It took you {numberOfGuesses} guesses!");

            Console.WriteLine("Do you want to play again? (yes or no) ");
            play = Console.ReadLine();
        }              
    }
}