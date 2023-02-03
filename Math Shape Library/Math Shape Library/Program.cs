using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Shape_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a shape: 1 for Triangle, 2 for Circle");
            var shapeType = Console.ReadLine();

            IShape2D shape = null;

            if(shapeType=="1")
            {
                double a, b, c;

                Console.WriteLine("Side length A: ");
                a  = double.Parse(Console.ReadLine());
                Console.WriteLine("Side length B: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Side length C: ");
                c = double.Parse(Console.ReadLine());

                shape = new Triangle(a, b, c);
            }
            else if(shapeType=="2")
            {
                double r;
                Console.WriteLine("Length radius: ");
                r = double.Parse(Console.ReadLine());
                shape = new Circle(r);
            }
            
            if (shape != null)
            {
                Console.WriteLine("Shape area: " + ShapeCalculator.GetArea(shape));
            }
            else
            {
                Console.WriteLine("Invalid shape selected.");
            }

            if (shape is Triangle triangle)
                Console.WriteLine("Triangle is rectangular: " + triangle.IsRectangular());
            Console.ReadLine();
        }
    }
}
