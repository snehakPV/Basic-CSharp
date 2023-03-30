using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0,number;
        while(true)
        {
        Console.WriteLine("Enter the number: ");
        number=int.Parse(Console.ReadLine());
         sum+=number;
        
        if(number==0)
        {
           break;
        }
        }
       Console.WriteLine(sum);
         
    }
}
