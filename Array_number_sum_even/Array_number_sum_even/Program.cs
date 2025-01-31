// See https://aka.ms/new-console-template for more information

int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = 0;
for (int i = 0; i<numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        sum += numbers[i];
}
Console.WriteLine("Sum of the even numbers is: "+sum);