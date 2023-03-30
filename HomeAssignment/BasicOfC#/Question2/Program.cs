using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int number2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition= "+(number1+number2));
        Console.WriteLine("Subtraction= "+(number1-number2));
        Console.WriteLine("Multiplication= "+(number1*number2));
        Console.WriteLine("Division= "+(number1/number2));
        Console.WriteLine("Modulo= "+(number1%number2));
    }
}
