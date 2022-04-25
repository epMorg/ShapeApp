using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Factory
{
    public class ShapeFactory
    {
        public static Shape CreateCircle(double radius)
        {
            return new Circle(radius);
        }
        public static Shape CreateTriangle(double side1, double side2, double side3)
        {
            return new Triangle (side1, side2, side3);
        }
        public static Shape CreateQuadrilateral(double length, double width)
        {
            return new Quadrilateral(length, width);
        }
    }
}
