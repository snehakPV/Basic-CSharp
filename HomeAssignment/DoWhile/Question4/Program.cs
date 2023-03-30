using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
     int number,sum=0;
     Console.WriteLine("Enter the number: ");
     number=int.Parse(Console.ReadLine());
     do
     {
        sum+=number%10;
        number/=10;
     }while(number>0);  
     Console.WriteLine("The sum of the digits: "+sum);     
    }
    
}
