using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int Number=int.Parse(Console.ReadLine());
        int count=0;
        for(int i=1;i<=Number;i++)
        {
          if(Number%i==0)
          {
            count++;
          }
        }
        if(count==2)
        {
            Console.WriteLine("It is a prime number");
        }
        else
        {
            Console.WriteLine("It is not a prime number");
        }

    }
}
