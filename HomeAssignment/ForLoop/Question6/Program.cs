using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        double sum=0;
        System.Console.WriteLine("Enter number:");
        int number=int.Parse(Console.ReadLine());
        System.Console.Write("1");
        for(int i=2;i<=number;i++)
        {
            System.Console.Write("+1/{0}",i);
            sum+=1.0/i;
        }
        System.Console.WriteLine("Sum of Series:"+sum);

    }
}
