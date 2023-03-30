using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the number of terms");
        int number=int.Parse(Console.ReadLine());
        int sum=0;
        int num=1;
        for(int i=0;i<number;i++)
        {
         sum+=num;
         num=num*10+1;
        }
        System.Console.WriteLine("sum="+sum);
    }
}
