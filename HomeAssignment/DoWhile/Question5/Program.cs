using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        do
        {
         Console.WriteLine("Enter the number: ");
         number=int.Parse(Console.ReadLine());
        }while(number==0);
        Console.WriteLine("Multiplication table of {0}",number);
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine("{0}*{1}={2}",number,i,number*i);
        }
    }
}
