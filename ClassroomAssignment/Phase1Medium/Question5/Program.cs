using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the starting number: ");
        int Start=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the difference: ");
        int difference=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of elements: ");
        int elements=int.Parse(Console.ReadLine());
       
        int sum=0;
        for(int i=Start;i<=elements;i++)
        {
            
          int result=i+difference;
          difference++;
          Console.Write(result+" ");
          sum=sum+result;
          Start=0;
        }
        Console.WriteLine("The sum= "+sum);
    }
}
