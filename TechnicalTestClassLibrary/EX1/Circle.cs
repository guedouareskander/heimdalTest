using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTestClassLibrary
{
    public class Circle : Shape
    {
        public double radius { get; set; }
        public override double GetPerimeter()
        {
            return radius * 2 * 3.14;
        }

        public override string ToString()
        {
            return base.ToString().Replace("Shape","Circle") + " radius : " + radius + " Perimeter : " + this.GetPerimeter();
        }
    }
}
