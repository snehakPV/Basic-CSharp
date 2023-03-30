using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of rows:");
        int rows=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number of columns:");
        int columns=int.Parse(Console.ReadLine());
        for(int i=1;i<=rows;i++)
        {
            for(int j=1;j<=columns;j++)
            {
                if(i==1||i==rows||j==1||j==columns)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}
