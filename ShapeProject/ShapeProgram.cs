using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class ShapeProgram
    {
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) running = false;
            }
        }
        private void PrintMenu()
        {
            Console.WriteLine("Demo Shapes");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Square");
            Console.WriteLine("0. Exit");
        }
        private int GetChoice()
        {
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);
            return choice;
        }
        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: DemoCircle(); break;
                case 2: DemoRectangle(); break;
                case 3: break;
                case 0: Console.WriteLine("Bye!"); break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        private void PrintShape(string type, string name, double area, double perimeter)
        {
            Console.WriteLine("{0} {1} has S = {2:F2} and P = {3:F2}", type, name, area, perimeter);
        }
        private void DemoCircle()
        {
            Console.Write("Enter circle name: ");
            string name = Console.ReadLine();
            Console.Write("Enter circle radius: ");
            double radius = double.Parse(Console.ReadLine());
            Circle c = new Circle(name, radius);
            PrintShape(c.Type, c.Name, c.Area(), c.Perimeter());
        }
        private void DemoRectangle()
        {
            Console.Write("Enter rectangle name: ");
            string name = Console.ReadLine();
            Console.Write("Enter rectangle width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter rectangle height: ");
            double height = double.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(name, width, height);
            PrintShape(r.Type, r.Name, r.Area(), r.Perimeter());
        }
    }
}