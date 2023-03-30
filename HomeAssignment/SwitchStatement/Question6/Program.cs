using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number2: ");
        int number2=int.Parse(Console.ReadLine());
        switch(number1>number2)
        {
          case true:
          {
            Console.WriteLine(number1+" is Maximum number");
            break;
          }
          case false:
          {
            Console.WriteLine(number2+" is Maximum number");
            break;
          }
        }
    }
}
