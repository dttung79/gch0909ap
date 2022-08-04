using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle() : base("Default Circle")
        {
            // Name = "Default Circle";
            type = "Circle";
            Radius = 5.0;
        }
        public Circle(string name, double radius) : base(name)
        {
            type = "Circle";
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}