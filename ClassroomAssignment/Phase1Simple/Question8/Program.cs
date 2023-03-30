using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=1;i<=99;i+=2)
        {
         sum+=i*i;
        }
        Console.WriteLine("Sum of square of odd number from 1 to 99 = "+sum);
    }
}
