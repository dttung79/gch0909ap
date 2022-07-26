using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRSPOOP
{
    public class Game
    {
        private Player player;
        private Computer computer;
        private const int DRAW = 0;
        private const int WIN = 1;
        private const int LOSE = 2;

        private int count;


        public Game()
        {
            player = new Player();
            computer = new Computer();
        }
        public void Play()
        {
            bool playing = true;
            count = 0;
            PrintWelcome();
            while (playing)
            {
                string playerChoice = player.ChooseRSP();
                string computerChoice = computer.ChooseRSP();
                int result = Compare(playerChoice, computerChoice);
                player.UpdateScore(result);
                PrintResult(result);
                playing = player.ChooseContinue();
                count++;
            }
            PrintGoodbye();
        }
        private void PrintWelcome()
        {
            Console.WriteLine("Welcome {0} to Rock, Scissors, Paper!", player.Name);
        }
        private int Compare(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice) return DRAW;
            if (playerChoice == "Rock" && computerChoice == "Scissors") return WIN;
            return LOSE;
        }
        private void PrintResult(int result)
        {
            if (result == DRAW) Console.WriteLine("It's a draw!");
            if (result == WIN) Console.WriteLine("{0} win!", player.Name);
            if (result == LOSE) Console.WriteLine("{0} lose!", player.Name);
            Console.WriteLine("Current {0} score: {1}", player.Name, player.Score);
        }
        private void PrintGoodbye()
        {
            Console.WriteLine("Final {0} score: {1} / {2} games", player.Name, player.Score, count);
            Console.WriteLine("Thanks {0} for playing!", player.Name);
        }
    }
}