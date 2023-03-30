using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of X: ");
        int x=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of y: ");
        int y=int.Parse(Console.ReadLine());
        double result=Math.Pow(x,y);
        Console.WriteLine($"{x} to the power {y} = {result}");
    }
}
