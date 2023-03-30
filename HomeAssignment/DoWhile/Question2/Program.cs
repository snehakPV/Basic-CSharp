using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int count,number,sum=0;
        int increment=0;
        Console.WriteLine("Enter the number of integers: ");
        count=int.Parse(Console.ReadLine());
        do
        {
         Console.WriteLine("Enter the number: ");
         number=int.Parse(Console.ReadLine());
         if(number>0)
         {
            sum+=number;
         }
         increment++;
        }while(increment<count);
        Console.WriteLine("The sum of positive integers: "+sum);
    }
}
