using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Triangle : Shape
    {
        public static int InstanceCounter = 0;

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle()
        {

        }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            SetName();
            CalculatePerimeter();
            CalculateArea();

            InstanceCounter++;
        }
        protected override void CalculatePerimeter()
        {
            Perimeter = Side1 + Side2 + Side3;
        }
        protected override void CalculateArea()
        {
            var semiPerimeter = Perimeter / 2;
            Area = Math.Sqrt(semiPerimeter * ((semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3)));
        }

        private void SetName()
        {
            if (Side1 == Side2 && Side2 == Side3)
            {
                Name = "Equilateral";
            }
            else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
            {
                Name = "Isoceles";
            }
            else
            {
                Name = "Scalene";
            }
        }
    }

}

