using System;

namespace ShapeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            PrintShape(s.Type, s.Name, s.Area(), s.Perimeter());

            Circle c = new Circle("C1", 5.0);
            PrintShape(c.Type, c.Name, c.Area(), c.Perimeter());

            Rectangle r = new Rectangle("ABCD", 7.0, 2.0);
            PrintShape(r.Type, r.Name, r.Area(), r.Perimeter());
        }
        static void PrintShape(string type, string name, double area, double perimeter)
        {
            Console.WriteLine("{0} {1} has S = {2:F2} and P = {3:F2}", type, name, area, perimeter);
        }
    }
}
