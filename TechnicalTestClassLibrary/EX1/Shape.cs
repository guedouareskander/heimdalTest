using System;

namespace TechnicalTestClassLibrary
{
    public abstract class Shape
    {
        public Location Location { get; set; }
        public Shape()
        {
            Random random = new Random();
            double x = random.NextDouble();
            double y = random.NextDouble();
            Location = new Location()
            {
                X = x,
                Y = y
            };
        }
        public virtual double GetPerimeter()
        {
            return 0;
        }
        public override string ToString()
        {
            return "[ Shape ] : Location { x : " + Location.X + " , y : " + Location.Y + " }";
        }
    }
}
