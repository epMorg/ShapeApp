using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Circle : Shape
    {
        public static int InstanceCounter = 0;
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;

            CalculatePerimeter();
            CalculateArea();

            InstanceCounter++;
        }
        protected override void CalculatePerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
        }

        protected override void CalculateArea()
        {
            Area = Math.PI * Radius
                * Radius;
        }
    }
}

