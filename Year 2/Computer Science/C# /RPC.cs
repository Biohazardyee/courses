namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            bool hasWon = false;

            Console.WriteLine("Welcome to Rock, Paper, Scissors");

            while (playAgain)
            {
                player = "";
                computer = "";
                hasWon = false;

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Please enter your choice (rock, paper, scissors): ");
                    player = Console.ReadLine().ToUpper();
                }

                int computerChoice = random.Next(1, 4); // 1 for ROCK, 2 for PAPER, 3 for SCISSORS
                switch (computerChoice)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("You chose: " + player);
                Console.WriteLine("Computer chose: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose! Paper covers rock.");
                            hasWon = true;
                        }
                        else
                        {
                            Console.WriteLine("You win! Rock crushes scissors.");
                            hasWon = true;
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win! Paper covers rock.");
                            hasWon = true;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else
                        {
                            Console.WriteLine("You lose! Scissors cut paper.");
                            hasWon = true;
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose! Rock crushes scissors.");
                            hasWon = true;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win! Scissors cut paper.");
                            hasWon = true;
                        }
                        else
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        break;
                }

                if (hasWon)
                {
                    Console.WriteLine("Do you want to play again? (yes/no)");
                    string response = Console.ReadLine().ToLower();
                    if (response != "yes" && response != "y")
                    {
                        playAgain = false;
                        Console.WriteLine("Thanks for playing!");
                    }
                }
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
