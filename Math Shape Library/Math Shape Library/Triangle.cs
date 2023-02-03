using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Shape_Library
{
    internal class Triangle : IShape2D
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        
        public bool IsRectangular()
        {
            if(Math.Pow(c,2)== Math.Pow(a, 2)+ Math.Pow(b, 2))
                return true;
            else 
                return false;
        }
        public double GetArea()
        {
            double p = (a+b+c)/ 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
