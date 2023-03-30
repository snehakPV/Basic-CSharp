using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        int i,j,k,row=6;
        for(i=1;i<=row;i++)
        {
            for(j=1;j<=(row-i);j++)
            {
                Console.Write(" ");
            }
            for(k=1;k<i*2;k++)
            {
                Console.Write("*");
            }
             Console.WriteLine();
        }
    }
}