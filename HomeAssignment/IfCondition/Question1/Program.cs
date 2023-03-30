using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the grade:");
        int grade=int.Parse(Console.ReadLine());
        if(grade>=5.50)
        {
            Console.WriteLine("Excellant!");
        }
        else
        {
            Console.WriteLine("Not Excellant!");
        }

    }
}
