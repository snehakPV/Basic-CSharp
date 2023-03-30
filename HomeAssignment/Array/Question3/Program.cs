using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of elements: ");
        int number=int.Parse(Console.ReadLine());
        int [] array=new int[number];
        int sum=0;
        for(int i=0;i<number;i++)
        {
         System.Console.WriteLine($"Enter elements{i}=");
         array[i]=int.Parse(Console.ReadLine());
        }
        foreach(int elements in array)
        {
            sum+=elements;
        }
        Console.WriteLine($"Sum={sum}");
    }
}
