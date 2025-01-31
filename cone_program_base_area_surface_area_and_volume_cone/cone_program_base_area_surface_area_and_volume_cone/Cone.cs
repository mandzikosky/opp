using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cone_program_base_area_surface_area_and_volume_cone
{
    internal class Cone
    {
        public double CalculatingBase(double height, double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double CalculatingSurface(double height, double radius)
        {
            return Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
        }
        public double CalculatingVolume(double height, double radius)
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}