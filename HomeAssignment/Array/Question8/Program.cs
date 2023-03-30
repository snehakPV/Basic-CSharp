using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter size(less than 5)");
        int size=int.Parse(Console.ReadLine());
        int [,] matrix1=new int[size,size];
        int [,] matrix2=new int[size,size];
        System.Console.WriteLine("Elements in first matrix: ");
        for(int i=0;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                Console.Write($"Elements-[{0}],[{1}]:",i,j);
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Elements in second matrix");
        for(int i=0;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                Console.Write($"Elements-[{0}],[{1}]:",i,j);
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        int [,] result=new int[size,size];
        for(int i=0;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                result[i,j]=matrix1[i,j]+matrix2[i,j];
            }
        }
        System.Console.WriteLine("Sum:");
        for(int i=0;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                System.Console.Write("{0}\t",result[i,j]);
            }
            System.Console.WriteLine();
        }
    } 
}
