using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_homework_class_smartdevices_cas_seven
{
    internal class SmartDevices
    {
        public string name;
        public string color;
        public double megapixels;
        public double weight;

        public SmartDevices(string devicesName, string devicesColor, double devicesMegapixels, double devicesWeight)  //ova e konstruktor
        {
            name = devicesName;
            color = devicesColor;
            megapixels = devicesMegapixels;
            weight = devicesWeight;
        }
        public void Print(string Name)
        {
            Console.WriteLine("Name of Product: " + Name);
        }
        public void PrintColo(string Color)
        {
            Console.WriteLine("Color of Product: " + Color);
        }
        public void PrintMegapix(double Megapixels)

        {
            Console.WriteLine("Specificatons: " + Megapixels);
        }
        public void PrintWeight(double Weight)
        {
            Console.WriteLine("Weight: " + Weight + " kg");
        }
    }
}

