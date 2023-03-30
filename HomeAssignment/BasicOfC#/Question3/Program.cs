using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount of Celsius: ");
        int celsius=int.Parse(Console.ReadLine());
        Console.WriteLine("Kelvin= "+(celsius+273.15));
        Console.WriteLine("Fahrenheit= "+((celsius*9/5)+32) );
    }
}
