// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
Console.WriteLine("Enter the points"); 
int points =Convert.ToInt32(Console.ReadLine());    
if (points <=59)
{
    Console.WriteLine($"With: {points} points Student not pass the exam");
}
else if (points >= 60 && points <= 69)
{
    Console.WriteLine($"With: {points} points Student pass the exam with 6 grade");
}

else if (points >= 70 && points <= 79)
{
    Console.WriteLine($"With: {points} points Student pass the exam with 7 grade");

}
else if (points >= 80 && points <= 89)
{
    Console.WriteLine($"With: {points} points Student pass the exam with 8 grade");
}
else
{
    Console.WriteLine($"With: {points} points Student pass the exam with 10 grade");
}





