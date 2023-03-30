using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=0;i<=10;i++)
        {
            sum+=i;
        }
        Console.WriteLine("Sum: "+sum);
    }
}