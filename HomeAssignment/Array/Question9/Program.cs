using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter row1 and column1:");
        int row1=int.Parse(Console.ReadLine());
        int column1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter row2 and column2:");
        int row2=int.Parse(Console.ReadLine());
        int column2=int.Parse(Console.ReadLine());
        if(column1!=row2)
        {
            System.Console.WriteLine("Matrix cannot multiplied");
        }
        else
        {
            int [,] matrix1=new int[row1,column1];
            int [,] matrix2=new int[row2,column2];
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<column1;j++)
                {
                    matrix1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<row2;i++)
            {
                for(int j=0;j<column2;j++)
                {
                    matrix2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            int [,] result=new int[row1,column2];
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<column2;j++)
                {
                    for(int k=0;k<column1;k++)
                    {
                        result[i,j]+=matrix1[i,k]*matrix2[k,j];
                    }
                }
            }
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<column1;j++)
                {
                    System.Console.Write(matrix1[i,j]+" ");
                }
            }
            for(int i=0;i<row2;i++)
            {
                for(int j=0;j<column2;j++)
                {
                     System.Console.Write(matrix2[i,j]+" ");
                }
            }
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<column2;j++)
                {
                     System.Console.Write(result[i,j]+" ");
                }
            }

        }

    }
}
