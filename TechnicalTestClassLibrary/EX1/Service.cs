using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechnicalTestClassLibrary
{
    public class Service
    {
        public List<Shape> GetShapes(int n)
        {

            List<Shape> shapes = new List<Shape>();
            Shape newShape;
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int coinFace = random.Next(2);// 1 : Circle ; 0 : rectangle
                if (coinFace == 0)
                {
                    if (i == 0)
                    {
                        newShape = new Rectangle()
                        {
                            Side1 = 0,
                            Side2 = 0
                        };
                    }
                    else
                    {
                        double s1 = random.NextDouble() * i / 2;
                        newShape = new Rectangle()
                        {
                            Side1 = s1,
                            Side2 = (double)(i) / 2 - s1
                        };
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        newShape = new Circle()
                        {
                            Radius = 0
                        };
                    }
                    else
                    {
                        newShape = new Circle()
                        {
                            Radius = i / 6.28
                        };
                    }
                }

                shapes.Add(newShape);
            }

            return shapes;
        }

        public double GetSumOfCircles(List<Shape> shapes)
        {
            double sum = 0;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is Circle)
                {
                    sum += shapes[i].GetPerimeter();
                }
            }
            return sum;
        }

        public double GetSumOfCirclesWithParallel(List<Shape> shapes)
        {
            double sum = 0;
            Parallel.ForEach(shapes, new ParallelOptions { MaxDegreeOfParallelism = 2 }, shape =>
            {
                if (shape is Circle)
                {
                    sum += shape.GetPerimeter();
                }
            });
            return sum;
        }
    }
}
