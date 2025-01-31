// See https://aka.ms/new-console-template for more information

double[] decimall = { 3.15, 33.6566, 98.357, 785.2000, 45612.874, 2.4, 1.9878999, 32.14 };

double max=decimall[0];
double min = decimall[0];
foreach(double d in decimall)
{
    if (d> max)
    {
        max = d;
    }
    if (d < min)
    {
        min = d;
    }

}

Console.WriteLine("Maximal number is: " + max);
Console.WriteLine("Minimal number is: " + min);
