using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the start value:");
        int start=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the end value:");
        int end=int.Parse(Console.ReadLine());
        for(int i=start;i<=end;i++)
        {
            int sum=0;
            int temp=i;
            int length=i.ToString().Length;
            while(temp!=0)
            {
                int digit=temp%10;
                sum+=(int)Math.Pow(digit,length);
                temp/=10;
            }
            if(sum==i)
            {
                System.Console.Write(i+" ");
            }
        }
    }
}
