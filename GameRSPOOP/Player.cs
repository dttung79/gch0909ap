using System;

namespace GameRSPOOP
{
    public class Player
    {
        private const int DRAW = 0;
        private const int WIN = 1;
        private const int LOSE = 2;
        
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int score;
        public int Score
        {
            get { return score; }
        }

        public void UpdateScore(int result)
        {
            if (result == WIN) score++;
            else if (result == LOSE) score--;
        }

        public Player()
        {
            Console.Write("Enter player name: ");
            Name = Console.ReadLine();
        }
        public string ChooseRSP()
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
        public bool ChooseContinue()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string answer = Console.ReadLine();
            return answer == "y";
        }
    }
}