using System;

namespace FractionProject
{
    public abstract class MenuProgram
    {
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                running = choice != 0;
            }
        }

        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);

        protected int GetChoice()
        {
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}