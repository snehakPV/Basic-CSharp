using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the speed: ");
        int speed=Convert.ToInt32(Console.ReadLine());
        int time=20;
        Console.WriteLine("Distance travelled= "+speed*time*5/18+ " meters");
    }
}
