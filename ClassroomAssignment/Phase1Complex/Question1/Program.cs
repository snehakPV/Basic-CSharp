using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int [,] matrixA={{1,2,3},{4,5,6}};
        int [,] matrixB={{7,8},{9,10},{11,12}};
        int rowA=matrixA.GetLength(0);
        int columnA=matrixA.GetLength(1);
        int rowB=matrixB.GetLength(0);
        int columnB=matrixB.GetLength(1);

        if(columnA!=rowB)
        {
            System.Console.WriteLine("Cannot Multiply");
        }
        else
        {
            int [,] result=new int[rowA,columnB];
            for(int i=0;i<rowA;i++)
            {
                for(int j=0;j<columnB;j++)
                {
                    for(int k=0;k<columnA;k++)
                    {
                        result[i,j]+=matrixA[i,k]*matrixB[k,j];
                    }
                }
            }
            for(int i=0;i<rowA;i++)
            {
                for(int j=0;j<columnB;j++)
                    {
                        System.Console.Write(result[i,j]+"\t");
                    }
                System.Console.WriteLine();
            }
        }
    }
}
