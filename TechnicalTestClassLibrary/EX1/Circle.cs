namespace TechnicalTestClassLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetPerimeter()
        {
            return Radius * 2 * 3.14;
        }

        public override string ToString()
        {
            return base.ToString().Replace("Shape", "Circle") + " radius : " + Radius + " Perimeter : " + this.GetPerimeter();
        }
    }
}
