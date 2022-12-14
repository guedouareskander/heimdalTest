namespace TechnicalTestClassLibrary
{
    public class Rectangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public override double GetPerimeter()
        {
            return (Side1 + Side2) * 2;
        }
        public override string ToString()
        {
            return base.ToString().Replace("Shape", "Rectangle") + " side1 : " + Side1 + " side2 : " + Side2 + " Perimeter : " + this.GetPerimeter();
        }
    }
}
