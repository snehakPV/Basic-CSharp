using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length: ");
        int meter=int.Parse(Console.ReadLine());
        int cm=meter*100;
        int mm=cm*10;
        float inch= (float)(meter * 39.3);
        int foot =12*meter;
        decimal mile= (decimal)(0.0006213715277778 * meter);
        Console.WriteLine("CM= "+cm);
        Console.WriteLine("MM= "+mm);
        Console.WriteLine("Inch= "+inch);
        Console.WriteLine("Foot= "+foot);
        Console.Write("Mile= "+mile);
    }
}
