// See https://aka.ms/new-console-template for more information

string[] cars = {"Porsche", "Lexus", "Genesis", "Maybach", "Alfa Romeo", "Jaguar", "Infiniti", "Honda", "Maserati" };

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

foreach (string car in cars)
{
    Console.WriteLine(car);
}

