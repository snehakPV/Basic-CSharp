using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value1: ");
        int value1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2: ");
        int value2=int.Parse(Console.ReadLine());
        Console.WriteLine("Select the operation:\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                int Addition=value1+value2;
                Console.WriteLine(Addition);
             break;
            }
            case 2:
            {
                int Subtraction=value1-value2;
                Console.WriteLine(Subtraction);
                break;
            }
            case 3:
            {
                int Multiplication=value1*value2;
                Console.WriteLine(Multiplication);
                break;
            }
            case 4:
            {
                int Division=value1/value2;
                Console.WriteLine(Division);
                break;
            }
            default:
            {
                break;
            }
        }
    }
}
