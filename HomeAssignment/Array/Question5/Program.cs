using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of elements:");
        int number=int.Parse(Console.ReadLine());
        int [] array=new int[number];
        int [] odd=new int [number];
        int [] even=new int[number];
        int oddIndex=0;
        int evenIndex=0;
        for(int i=0;i<number;i++)
        {
         System.Console.WriteLine($"Enter element-{i}:");
         array[i]=int.Parse(Console.ReadLine());
        }
        foreach(int element in array)
        {
            if(element%2==0)
            {
                even[evenIndex++]=element;
            }
            else
            {
                odd[oddIndex++]=element;
            }
        }
        System.Console.WriteLine("Even Element:");
        for(int i=0;i<evenIndex;i++)
        {
            System.Console.Write(even[i]);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Odd Element: ");
        for(int i=0;i<oddIndex;i++)
        {
            System.Console.WriteLine(odd[i]);
        }
    }
}
