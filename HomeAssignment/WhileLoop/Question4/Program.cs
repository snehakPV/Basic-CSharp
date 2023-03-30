using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine()),sum=0;
        while(number>=0)
        {
         sum+=number;
         number--;
        }
        Console.WriteLine("Sum= "+sum);
    
    }
}
