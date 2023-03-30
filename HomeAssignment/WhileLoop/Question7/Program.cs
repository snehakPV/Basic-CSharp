using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int start=1;
        Console.WriteLine("Even Numbers");
        while(start<=100)
        {
          if(start%2==0)
          {
            Console.WriteLine(start);
            
          }
          start++;
        }
        Console.WriteLine("Odd Numbers");
        start=1;
        while(start<=100)
        {
          if(start%2!=0)
          {
            Console.WriteLine(start);
            
          }
          start++;
        }
        Console.WriteLine("Prime Numbers:");
         start=2;
        while(start<=100)
        {
           bool isPrime=true;
           int i=2;
         while(i<=start/2)
         {
           
            if(start%i==0)
            {
                isPrime=false;
                break;
            }
            i++;
            }
         
         if(isPrime)
            {
                Console.WriteLine(start+ " ");
            }
         start++;
        }
        Console.ReadLine();
    }
}
