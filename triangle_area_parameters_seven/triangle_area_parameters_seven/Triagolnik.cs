using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_area_parameters_seven
{
    internal class Triagolnik
    {

      

        public double CalculateArea(double height, double basse)
        {
            return 0.5 * basse * height;
        }


   
        public double CalculatePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;

        }
    }
}