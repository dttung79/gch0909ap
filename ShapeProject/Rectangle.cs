using System;

namespace ShapeProject
{
    public class Rectangle : Shape
    {
        protected double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height { get; set; }

        public Rectangle() : base("Default Rectangle")
        {
            type = "Rectangle";
            Width = 10.0;
            Height = 5.0;
        }
        public Rectangle(string name, double width, double height) : base(name)
        {
            type = "Rectangle";
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}