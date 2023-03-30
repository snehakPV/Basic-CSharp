using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size");
        int size=int.Parse(Console.ReadLine());
        int [] array=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine($"Enter elements-{i}:");
            array[i]=int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        System.Console.WriteLine("Sorted Array");
        foreach(int elements in array)
        {
            System.Console.WriteLine(elements);
        }
    }
}
