using System;

namespace GameRSP
{
    class Program
    {
        const int DRAW = 0;
        const int WIN = 1;
        const int LOSE = 2;

        static void Main(string[] args)
        {
            bool playing = true;
            PrintWelcome();
            while (playing)
            {
                string playerChoice = PlayerChooseRSP();
                string computerChoice = ComputerChooseRSP();
                int result = Compare(playerChoice, computerChoice);
                PrintResult(result);
                playing = PlayerChooseContinue();
            }
            PrintGoodbye();
        }
        static void PrintWelcome()
        {
            Console.WriteLine("Welcome to Rock, Scissors, Paper!");
        }
        static string PlayerChooseRSP()
        {
            bool invalid = true;
            string playerChoice = "";
            while (invalid)
            {
                Console.WriteLine("Please choose one of the following: Rock, Scissors, Paper");
                playerChoice = Console.ReadLine();
                invalid = playerChoice != "Rock" && playerChoice != "Scissors" && playerChoice != "Paper";
                if (invalid) Console.WriteLine("Invalid choice. Please try again.");
            }
            return playerChoice;
        }
        static string ComputerChooseRSP()
        {
            string[] choices = { "Rock", "Scissors", "Paper" };
            Random random = new Random();
            int index = random.Next(0, 3);
            Console.WriteLine("The computer chose " + choices[index]);
            return choices[index];
        }
        static int Compare(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice) return DRAW;
            if (playerChoice == "Rock" && computerChoice == "Scissors") return WIN;
            else if (playerChoice == "Scissors" && computerChoice == "Paper") return WIN;
            else if (playerChoice == "Paper" && computerChoice == "Rock") return WIN;
            else return LOSE;
        }
        static void PrintResult(int result)
        {
            if (result == DRAW) Console.WriteLine("It's a draw!");
            else if (result == WIN) Console.WriteLine("You win!");
            else Console.WriteLine("You lose!");
        }

        static bool PlayerChooseContinue()
        {
            Console.Write("Do you want to play again? (y/n): ");
            string answer = Console.ReadLine();
            return answer == "y";        
        }
        static void PrintGoodbye()
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}
