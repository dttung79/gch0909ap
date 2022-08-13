using System;

namespace DemoCustomException
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set 
            { 
                if (Valid(value, b, c))
                    a = value;
                else
                {
                    throw new TriangleException("Invalid value for a");
                }
            }
        }

        public double B
        {
            get { return b; }
            set 
            { 
                if (Valid(a, value, c))
                    b = value;
                else
                {
                    throw new TriangleException("Invalid value for b");
                }
            }
        }
        public double C
        {
            get { return c; }
            set 
            { 
                if (Valid(a, b, value))
                    c = value;
                else
                {
                    throw new TriangleException("Invalid value for c");
                }
            }
        }
        private bool Valid(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return false;
            if (a + b <= c) return false;
            if (a + c <= b) return false;
            if (b + c <= a) return false;
            return true;
        }

        public Triangle()
        {
            a = b = c = 1;
        }
        public Triangle(double a, double b, double c)
        {
            if (Valid(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new TriangleException("a, b, c are not valid triangle sides");
            }
        }
        public override string ToString()
        {
            return "(" + a + ", " + b + ", " + c + ")";
        }
    }
}