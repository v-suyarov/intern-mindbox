using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Shape_Library
{

    class Circle:IShape2D
    {
        public double radius { get; private set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI* Math.Pow(radius,2);
        }
    }
}
