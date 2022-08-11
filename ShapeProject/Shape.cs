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
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Perimeter()
        {
            return 0;
        }

        public void Print()
        {
            Console.WriteLine("{0} {1}: A = {2}, P = {3}", type, name, Area(), Perimeter());
        }
    }
}