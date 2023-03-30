using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int value=int.Parse(Console.ReadLine()),sum=0,number=value;
        while(number!=0)
        {
          int number1=number%10;
          sum=sum*10+number1;
          number/=10;
        }
        Console.WriteLine(sum);
    }
}
