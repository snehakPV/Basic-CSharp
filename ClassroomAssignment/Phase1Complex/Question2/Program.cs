using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        double sum=1.0;
        double factorial=1.0;
        for(int i=1;i<=8;i++)
        {
            factorial*=i;
            sum+=Math.Pow(2,i)/factorial;
        }
        System.Console.WriteLine("Sum: "+sum);
    }
}
