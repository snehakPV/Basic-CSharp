using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the INR value: ");
        double inr=double.Parse(Console.ReadLine());
        double usd=1.22;
        double eur=1.27;
        double cny=8.79;
        double usdValue=inr/100*usd;
        double eurValue=inr/100*eur;
        double cnyValue=inr/100*cny;
        Console.WriteLine($"{inr} Rs={usdValue} USD");
        Console.WriteLine($"{inr} Rs={eurValue} EUR");
        Console.WriteLine($"{inr} Rs={cnyValue} CNY");
    }
}
