using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Triangle : Shape
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public Triangle() : base("Default Triangle")
        {
            type = "Triangle";
            SideA = 3.0;
            SideB = 4.0;
            SideC = 5.0;
        }
        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            type = "Triangle";
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}