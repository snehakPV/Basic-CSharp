using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        switch(number%2==0)
        {
         case true:
         {
            Console.WriteLine("Even");
            break;
         }
         case false:
         {
            Console.WriteLine("Odd");
            break;
         }
        }
    }
}
