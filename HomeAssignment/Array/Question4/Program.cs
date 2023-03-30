using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of elements: ");
        int number=int.Parse(Console.ReadLine());
        int [] array=new int [number];
        for(int i=0;i<number;i++)
        {
            System.Console.WriteLine($"Enter elements{i}=");
            array[i]=int.Parse(Console.ReadLine());
        }
        int max=array[0];
        int min=array[0];
        foreach(int elements in array)
        {
            if(elements>max)
            {
                max=elements;
            }
            if(elements<min)
            {
                min=elements;
            }
        }
        Console.WriteLine($"Maximum element={max}");
        System.Console.WriteLine($"Minimum element={min}");
    }
}
