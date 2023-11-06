namespace Numberguess
{
    internal class Program
    {
        static void StartGame()
        {
            bool IsCorrectGuess = false;
            int Flag = 0;
            Random RandomInt = new Random();

            int RandomNum = RandomInt.Next(1, 11);
            Console.WriteLine("Let's play the game ");
            Console.WriteLine("Guess the number between 1 to 10 friends \nyou have 3 guess");


            int ExtraLifeFlag = 0;

            while (!IsCorrectGuess && Flag <= 3 && ExtraLifeFlag == 0)
            {

                try
                {
                    if (Flag == 3)
                    {
                        Console.WriteLine("Don't worry restart the game \n->A - Add extra 1 guess \n->Any Key  - Exit");
                        string Choice = Console.ReadLine().ToLower();
                        switch (Choice)
                        {
                            case "a":
                                {
                                    Flag--;
                                    ExtraLifeFlag++;
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    Console.WriteLine("Enter your guess");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == RandomNum)
                    {
                        Console.WriteLine("Hey!  you are awesome ");
                        IsCorrectGuess = true;
                        break;
                    }
                    else if (guess > RandomNum)
                    {
                        Console.WriteLine("I am appreciating you are thinking big but not now ");
                        Flag++;
                    }
                    else
                    {
                        Console.WriteLine("Think big ");
                        Flag++;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }



            }
            Console.WriteLine("Enter to Continue");
            Console.ReadKey();
            Console.Clear();
            

        }
        static void EndGame()
        {
            Console.WriteLine("Thanks for playing!");
        }
        static void Main(string[] args)
        {
            

            StartGame();
            
            Console.Clear();
            Console.WriteLine("Enter the key \n->N-New game \n->Any key-To Exit");
            string UserChoice = Console.ReadLine().ToLower();
            switch(UserChoice)
            {
                case "n":
                    {
                        Console.Clear();
                        StartGame();
                        break;
                    }
                default:
                    {
                        EndGame();
                        break;
                    }
            }
            
            Console.ReadKey();

        }
    }
}