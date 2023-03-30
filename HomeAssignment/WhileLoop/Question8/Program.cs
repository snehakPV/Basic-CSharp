using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        int number1=0,number2=1,number3;
        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine("Enter the number times to repeat: ");
        int repeat=int.Parse(Console.ReadLine());
        while(number1<=repeat)
        {
         Console.WriteLine(number3=number1+number2);
         number1=number2;
         number2=number3;
        }
    }
}
