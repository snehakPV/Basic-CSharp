using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        if(number>=0)
        {
        Console.WriteLine(number+" is Positive Number");
        }
        else
        {
            Console.WriteLine(number+" is Negative Number");
        }
    }
}
