using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value=Convert.ToInt32(Console.ReadLine());
       // int result=value;
        int number,sum=0;
        while(value>0){
             number=value%10;
             sum=sum+number;
             value=value/10;
            }
            Console.WriteLine(sum);
    }
}
