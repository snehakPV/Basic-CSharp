using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter rows and columns:");
        int rows=int.Parse(Console.ReadLine());
        int columns=int.Parse(Console.ReadLine());
        int [,] matrix=new int[rows,columns];
        int [,] transpose=new int[columns,rows];
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
                System.Console.Write("Element[{0},{1}]:",i,j);
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
                System.Console.Write(matrix[i,j]+" ");
            }
            System.Console.WriteLine();
        }
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
                transpose[j,i]=matrix[i,j];
            }
        }
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
               System.Console.Write( transpose[j,i]+" ");
            }
            System.Console.WriteLine();
        }
    }
}
