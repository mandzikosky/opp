using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_seven_zadaca_one
{
    internal class shirt
    {
        public string color;
        public string size;

        public shirt(string shirtColor, string shirtSize)
        {
            color = shirtColor;
            size = shirtSize;
        }

        
        public void PrintColor(string color)
        {
            Console.WriteLine("Color of the shirt is " + color+" color");
            

        }
       public void PrintSize(string size)
        {
            Console.WriteLine("Size of the shirt is " + size + " size");
        }




    }
}
