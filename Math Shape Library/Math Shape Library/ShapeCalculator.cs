using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Shape_Library
{
    enum ShapeType
    {
        Triangle,
        Circle
    }
    static class ShapeCalculator
    {
        public  static double GetArea(IShape2D shape)
        {
            return shape.GetArea();
        }
        
        //other methods...
    }
}
