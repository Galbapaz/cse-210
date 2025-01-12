using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random(); 
        bool playAgain = true; 

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101); 
            int guessCount = 0; 
            int guess = 0; 

            Console.WriteLine("Welcome to the Guess My Number game!");
            Console.WriteLine("I have selected a magic number between 1 and 100. Can you guess it?");
            
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++; 

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
