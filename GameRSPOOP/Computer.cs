using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRSPOOP
{
    public class Computer
    {
        public string ChooseRSP()
        {
            string[] choices = new string[] { "Rock", "Scissors", "Paper" };
            Random random = new Random();
            int index = random.Next(0, choices.Length);
            Console.WriteLine("Computer chose " + choices[index]);
            return choices[index];
        }
    }
}