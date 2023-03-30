using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int [,] matrix=new int[3,3];
        Console.WriteLine("Enter elements:");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
             System.Console.Write($"Elements-{i}{j}:");
             matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("\nMatrix:");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
             System.Console.Write(matrix[i,j]+" ");
            }
            System.Console.WriteLine();
        }
    }
}
