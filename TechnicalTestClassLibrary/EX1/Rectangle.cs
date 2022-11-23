using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTestClassLibrary
{
    public class Rectangle : Shape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public override double GetPerimeter()
        {
            return (side1+side2) * 2;
        }
        public override string ToString()
        {
            return base.ToString().Replace("Shape", "Rectangle") + " side1 : " + side1 + " side2 : " + side2 + " Perimeter : " + this.GetPerimeter();
        }
    }
}
