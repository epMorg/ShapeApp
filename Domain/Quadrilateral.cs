using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Quadrilateral : Shape
    {
        public static int InstanceCounter = 0;

        public double Length { get; set; }
        public double Width { get; set; }

        public Quadrilateral()
        {

        }
        public Quadrilateral(double length, double width)
        {
            Length = length;
            Width = width;

            SetName();
            CalculatePerimeter();
            CalculateArea();

            InstanceCounter++;
        }
        protected override void CalculatePerimeter()
        {
            Perimeter = (Length + Width) * 2;
        }
        protected override void CalculateArea()
        {
            Area = Length * Width;
        }
        private void SetName()
        {
            Name = Length == Width ? "Square" : "Rectangle";
        }
    }
}
