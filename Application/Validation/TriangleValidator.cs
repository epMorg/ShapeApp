using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation
{
    public class TriangleValidator
    {
        public static bool IsValidTriangle(double side1, double side2, double side3)
        {
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                return true;
            }
            else
            {
                return false;
            }               
        }
    }
}
