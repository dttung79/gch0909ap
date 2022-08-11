using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class EqTriangle : IsoTriangle
    {
        public double Side 
        {
            get { return sideA; }
            set 
            { 
                sideA = value;
                sideB = value; 
                sideC = value;
            }
        }
        public EqTriangle() : base("Default EqTriangle", 3.0, 3.0)
        {
            type = "EqTriangle";
        }
        public EqTriangle(string name, double side) : base(name, side, side)
        {
            type = "EqTriangle";
        }
    }
}