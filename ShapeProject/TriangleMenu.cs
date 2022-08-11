using System;
using System.Collections.Generic;

namespace ShapeProject
{
    public class TriangleMenu
    {
        private List<Triangle> triangles;
        public List<Triangle> Triangles
        {
            get { return triangles; }
        }
        public TriangleMenu()
        {
            triangles = new List<Triangle>();
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
            Console.WriteLine("1. Add Normal Triangle.");
            Console.WriteLine("2. Add Equilateral Triangle.");
            Console.WriteLine("3. Add Isosceles Triangle.");
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
                case 1: AddNormalTriangle();                    break;
                case 2: AddEquilateralTriangle();               break;
                case 3: AddIsoscelesTriangle();                 break;
                case 0:                                         break;
                default: Console.WriteLine("Invalid choice.");  break;
            }
        }
        private void AddNormalTriangle()
        {
            Console.Write("Enter the triangle's name: ");
            string name = Console.ReadLine();
            // side1, side2, side3
            Console.Write("Enter the triangle's side1: ");
            double sidea = double.Parse(Console.ReadLine());
            Console.Write("Enter the triangle's side2: ");
            double sideb = double.Parse(Console.ReadLine());
            Console.Write("Enter the triangle's side3: ");
            double sidec = double.Parse(Console.ReadLine());
            triangles.Add(new Triangle(name, sidea, sideb, sidec));
        }
        private void AddEquilateralTriangle()
        {
            Console.Write("Enter the triangle's name: ");
            string name = Console.ReadLine();
            // side, side, side
            Console.Write("Enter the triangle's side: ");
            double side = double.Parse(Console.ReadLine());
            triangles.Add(new EqTriangle(name, side));
        }
        private void AddIsoscelesTriangle()
        {
            Console.Write("Enter the triangle's name: ");
            string name = Console.ReadLine();
            // side, side, side
            Console.Write("Enter the iso triangle's base side: ");
            double baseSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the iso triangle's side: ");
            double side = double.Parse(Console.ReadLine());
            triangles.Add(new IsoTriangle(name, baseSide, side));
        }
    }
}