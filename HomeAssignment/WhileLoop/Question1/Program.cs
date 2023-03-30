using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Input: ");
        int input=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=0;i<input;i++)
        {
            Console.WriteLine("Enter the number= ");
            int number=int.Parse(Console.ReadLine());
            sum+=number;
        }
        Console.WriteLine("Sum= "+sum);
    }
}
