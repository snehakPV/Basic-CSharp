using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the count: ");
        int count=int.Parse(Console.ReadLine()),sum=0;
        while(count!=0)
        {
         Console.WriteLine(count);
         sum+=count*count;
         count--;
         
        }
        Console.WriteLine(sum);
    }
}
