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
                        string Choice = " ";
                        Choice = Console.ReadLine().ToLower();
                        if (Choice == "a" && ExtraLifeFlag<=1)
                        {
                            Flag--;
                            ExtraLifeFlag++;
                            break;
                        }
                        else
                        {
                            EndGame();
                            break;
                        }
                    }
                    Console.WriteLine("Enter your guess");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == RandomNum)
                    {
                        if (Flag == 0)
                        {
                            Console.WriteLine("Whoo hoo! 20 points");
                        }else if(Flag==1){
                            Console.WriteLine("Awesome! 15 points");
                        }
                        else if (Flag == 2 && ExtraLifeFlag==1) {
                            Console.WriteLine("Hoo! you got 5 points");
                        }
                        else
                        {
                            Console.WriteLine("Perfect ! You got 10 points");
                        }
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
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Enter to new game....");
            Console.ReadKey();

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