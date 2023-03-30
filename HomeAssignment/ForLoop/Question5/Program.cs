using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
         double sum=0;
        for(int i=1;i<=number;i++)
       
        {
         sum+=i*i*i;
         Console.WriteLine($"Sum of cube of {i} is {sum}");
        }
        
    }
}
