using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int [] numbers=new int[10];
        int sum=0;
        Console.WriteLine("Enter the number");
        for(int i=0;i<10;i++)
        {
            Console.WriteLine($"Numbers-{i+1}");
            numbers[i]=int.Parse(Console.ReadLine());
            sum+=numbers[i];
        }
        double average=(double)sum/10.0;
        Console.WriteLine($"Sum={sum}\nAverage={average}");
    }
}
