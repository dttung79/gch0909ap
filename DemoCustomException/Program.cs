using System;

namespace DemoCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = GetTriangle("Enter triangle ABC:\n");
            Console.WriteLine(t);

            Triangle h = GetTriangle("Enter triangle HIK:\n");
            Console.WriteLine(h);
        }
        static double GetDouble(string message)
        {
            bool invalid = true;
            double number = 0;
            while (invalid)
            {
                Console.Write(message);
                try 
                {
                    number = double.Parse(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Must be double!");
                }
            }
            return number;
        }
        static Triangle GetTriangle(string message)
        {
            // TODO: enter 3 sides of a triangle until they are valid
            double a, b, c;
            Triangle t = new Triangle();
            bool invalid = true;
            while (invalid)
            {
                Console.Write(message);
                try
                {
                    a = GetDouble("Enter side a: ");
                    b = GetDouble("Enter side b: ");
                    c = GetDouble("Enter side c: ");
                    t = new Triangle(a, b, c);
                    invalid = false;
                }
                catch (TriangleException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return t;
        }
    }
}
