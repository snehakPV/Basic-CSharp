using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number2: ");
        int number2=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number3: ");
        int number3=int.Parse(Console.ReadLine());
        if(number1>number2 && number1>number3)
        {
            Console.WriteLine("The 1st number is largest among 3");
        }
        else if(number2>number1 && number2>number3)
        {
          Console.WriteLine("The 2nd number is largerst among 3");
        }
        else
        {
            Console.WriteLine("The 3rd number is largest among 3");
        }
    }
}
