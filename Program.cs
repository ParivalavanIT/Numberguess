using System;

namespace NumberGuess
{
    internal class Program
    {
        // Initialize a random number generator
        static Random random = new Random();

        // Generate a random number between min and max (inclusive)
        static int GenerateRandomNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        // Get a valid guess from the user
        static int GetGuess()
        {
            int guess;
            while (true)
            {
                Console.WriteLine("Enter your guess:");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    return guess;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        // Calculate the score based on the number of attempts
        static int CalculateScore(int attempts)
        {
            if (attempts == 3)
            {
                return 20;
            }
            else if (attempts == 2)
            {
                return 15;
            }
            else if (attempts == 1)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }

        // Display end game message with score and correct number
        static void EndGame(int score, int num)
        {
            if (score > 0)
            {
                Console.WriteLine($"Congratulations! {num} is the right answer, You got {score} points!");
            }
            else
            {
                Console.WriteLine($"Better luck next time! {num} is not right");
            }
            Console.WriteLine("Press Enter to start a new game...");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int attempts = 3;
                int guess;

                Console.Clear();
                Console.WriteLine("Let's play the game ");
                Console.WriteLine("Guess the number between 1 to 10 friends \nyou have 3 guesses");

                int randomNumber = GenerateRandomNumber(1, 10);

                while (attempts > 0)
                {
                    guess = GetGuess();

                    if (guess == randomNumber)
                    {
                        int score = CalculateScore(attempts);
                        EndGame(score, guess);
                        break;
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("I am appreciating you are thinking big but not now ");
                    }
                    else
                    {
                        Console.WriteLine("Think big ");
                    }

                    attempts--;
                }

                if (attempts == 0)
                {
                    EndGame(0, randomNumber);
                }
            }
        }
    }
}
