using System;

namespace ShapeProject
{
    public class Square : Rectangle
    {
        public double Side
        {
            get { return Width; }
            set 
            { 
                Width = value; 
                Height = value;
            }
        }
        public Square() : base("Default Square", 5.0, 5.0)
        {
            type = "Square";
        }
        public Square(string name, double side) : base(name, side, side)
        {
            type = "Square";
        }
    }
}