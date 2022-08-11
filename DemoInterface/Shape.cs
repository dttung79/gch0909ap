using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Shape
    {
        public string Name { get; set; }
        public Shape()
        {
            Name = "Default Shape";
        }
        public Shape (string name)
        {
            Name = name;
        }
    }
    public class Line : Shape, IDrawable
    {
        public int Length { get; set; }

        public Line() : base("XY")
        {
            Length = 10;
        }
        public Line(string name, int len) : base(name)
        {
            Length = len;
        }
        public void Draw()
        {
            Console.Write("+");
            for (int i = 0; i < Length; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine("+");
        }
    }
    public class Rectangle : Shape, IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle() : base("Rectangle")
        {
            Width = 10;
            Height = 3;
        }
        public Rectangle(string name, int width, int height) : base(name)
        {
            Width = width;
            Height = height;
        }
        public void Draw()
        {
            // draw upper line
            DrawLine("+", "--", Width);
            // draw 2 sides
            for (int i = 0; i < Height; i++)
            {
                DrawLine("|", "  ", Width);
            }
            // draw lower line
            DrawLine("+", "--", Width);
        }
        private void DrawLine(string beginSymbol, string middleSymbol, int length)
        {
            Console.Write(beginSymbol);
            for (int i = 0; i < length; i++)
            {
                Console.Write(middleSymbol);
            }
            Console.WriteLine(beginSymbol);
        }
    }
}