using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value=int.Parse(Console.ReadLine());
        if(value<100)
        {
            Console.WriteLine("Less than 100");
        }
        else if(value>=100 && value<200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
} 