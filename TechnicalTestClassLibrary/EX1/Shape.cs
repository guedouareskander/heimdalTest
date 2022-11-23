using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTestClassLibrary
{
    public class Shape
    {
        public Location Location { get; set; }
        public Shape()
        {
            Random random = new Random();
            double xx = random.NextDouble();
            random = new Random();
            double yy = random.NextDouble();
            Location = new Location()
            {
                x = xx,
                y = yy
            };
        }
        public virtual double GetPerimeter()
        {
            return 0;
        }
        public override string ToString()
        {
            return "[ Shape ] : Location { x : " + Location.x + " , y : " + Location.y + " }";
        }
    }
}
