using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Leap years from 1 to 2000: ");
        for(int i=1;i<=2000;i++)
        {
            if(i%4==0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
