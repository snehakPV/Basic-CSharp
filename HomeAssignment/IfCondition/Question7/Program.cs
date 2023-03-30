using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the year: ");
        int year=int.Parse(Console.ReadLine());
        if(year%4==0)
        {
          Console.WriteLine(year+" is leap year");
        }
        else
        {
            Console.WriteLine(year+" is not leap year");
        }
    }
}
