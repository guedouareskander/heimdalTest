using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestClassLibrary;
using TechnicalTestClassLibrary.EX2;

namespace TechnicalTestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX1
            Service service = new Service();

            //Get shapes 
            List<Shape> shapes = service.GetShapes(1000);
            shapes.ForEach(shape => Console.WriteLine(shape));

            //Get sum of perimeters
            double sum1 = service.GetSumOfCircles(shapes);
            Console.WriteLine(sum1);

            //Get sum of perimeters with parallel foreach
            double sum2 = service.GetSumOfCircles(shapes);
            Console.WriteLine(sum2);


            //EX2
            for(int i = 0; i <= 12; i++)
                for(int j = 0; j <= 60; j++)
                {
                    int angle = Clock.GeGetClockAngle(i, j);
                    
                    Console.WriteLine("Hour : " + i + " , Minutes : " + j + " , Angle : " + angle);
                }
        }
    }
}
