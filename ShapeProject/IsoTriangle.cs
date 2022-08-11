using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class IsoTriangle : Triangle
    {
        public double Base 
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public double Side
        {
            get { return sideB; }
            set 
            { 
                sideB = value; 
                sideC = value;
            }
        }
        public IsoTriangle() : base("Default IsoTriangle", 3.0, 4.0, 4.0)
        {
            type = "IsoTriangle";
        }
        public IsoTriangle(string name, double baseSide, double side) : base(name, baseSide, side, side)
        {
            type = "IsoTriangle";
        }
    }
}