using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int Number=int.Parse(Console.ReadLine());
        factorial(Number);
        
    }

    static void factorial(int Number)
    {
        int fact=1;
   for(int i=1;i<=Number;i++)
    {
        fact=fact*i;    
    }
     Console.WriteLine("The Factorial of "+Number+" is " +fact);
    }
}
