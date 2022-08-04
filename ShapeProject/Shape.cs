using System;

namespace ShapeProject
{
    public class Shape
    {
        protected string name;
        protected string type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
        }
        public Shape()
        {
            name = "No name";
            type = "Shape";
        }
        public Shape(string name)
        {
            Name = name;
            type = "Shape";
        }
        public double Area()
        {
            return 0;
        }
        public double Perimeter()
        {
            return 0;
        }
    }
}