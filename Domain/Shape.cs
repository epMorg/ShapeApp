using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Domain
{
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Quadrilateral))]
    [Serializable]
    public abstract class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }
        protected abstract void CalculateArea();
        protected abstract void CalculatePerimeter();

        public int CompareTo(Shape shape)
        {
            if (shape == null)
            {
                return 1;
            }

            else if (this.Area < shape.Area)
            {
                return -1;
            }

            else if (this.Area == shape.Area)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }

        public class PerimeterComparer : IComparer<Shape>
        {
            public int Compare(Shape first, Shape second)
            {
                if (first == null & second == null)
                {
                    return 0;
                }

                else if (first == null)
                {
                    return -1;
                }

                else if (second == null)
                {
                    return 1;
                }

                else if (first.Perimeter < second.Perimeter)
                {
                    return -1;
                }

                else if (first.Perimeter == second.Perimeter)
                {
                    return 0;
                }

                else

                {
                    return 1;
                }
            }
        }
    }
}
