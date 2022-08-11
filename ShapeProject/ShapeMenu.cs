using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class ShapeMenu
    {
        private List<Shape> shapes;
        public ShapeMenu()
        {
            shapes = new List<Shape>();
        }
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
        private void PrintMenu()
        {
            Console.WriteLine("1. Add Circle.");
            Console.WriteLine("2. Add Rectangle.");
            Console.WriteLine("3. Add Square.");
            Console.WriteLine("4. Add Triangle.");
            Console.WriteLine("5. Print all shapes.");
            Console.WriteLine("0. Back.");
        }
        private int GetChoice()
        {
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            return int.Parse(choice);
        }
        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddCircle();                            break;
                case 2: AddRectangle();                         break;
                case 3: AddSquare();                            break;
                case 4: AddTriangle();                          break;
                case 5: PrintShapes();                          break;
                case 0: Console.WriteLine("Bye!");              break;
                default: Console.WriteLine("Invalid choice.");  break;
            }
        }
        private void AddCircle()
        {
            Console.Write("Enter the circle's name: ");
            string name = Console.ReadLine();
            // radius
            Console.Write("Enter the circle's radius: ");
            double radius = double.Parse(Console.ReadLine());
            shapes.Add(new Circle(name, radius));
        }
        private void AddRectangle()
        {
            Console.Write("Enter the rectangle's name: ");
            string name = Console.ReadLine();
            // width
            Console.Write("Enter the rectangle's width: ");
            double width = double.Parse(Console.ReadLine());
            // height
            Console.Write("Enter the rectangle's height: ");
            double height = double.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(name, width, height));
        }
        private void AddSquare()
        {
            Console.Write("Enter the square's name: ");
            string name = Console.ReadLine();
            // side
            Console.Write("Enter the square's side: ");
            double side = double.Parse(Console.ReadLine());
            shapes.Add(new Square(name, side));
        }
        private void AddTriangle()
        {
            TriangleMenu tm = new TriangleMenu();
            tm.Run();
            // add triangles from tm to shapes
            foreach (Triangle t in tm.Triangles)
            {
                shapes.Add(t);
            }
        }
        private void PrintShapes()
        {
            foreach (Shape s in shapes)
            {
                s.Print();
            }
        }
    }
}