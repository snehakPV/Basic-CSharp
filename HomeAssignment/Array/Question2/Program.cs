using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number of elements: ");
        int number=int.Parse(Console.ReadLine());
        int [] array=new int[number];
        for(int i=0;i<number;i++)
        {
            System.Console.Write($"Enter the elements{i}");
            array[i]=int.Parse(Console.ReadLine());
        }
            System.Console.WriteLine("Array in reverse order:");
            Array.Reverse(array);
            foreach(int elements in array)
            {
                System.Console.WriteLine(elements);
            }
    }
}
