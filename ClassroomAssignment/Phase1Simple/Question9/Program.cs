using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int Number=int.Parse(Console.ReadLine());
        for(int i=1;i<=20;i++)
        {
            Console.WriteLine(Number+"*"+i+"="+Number*i);
        }
    }
}
