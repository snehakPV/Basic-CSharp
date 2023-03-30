using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        string repeat="";
        do{
        Console.WriteLine("Enter the input: ");
        int number=int.Parse(Console.ReadLine());
        if(number%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        Console.WriteLine("Do you need to repeat the process?");
        repeat=Console.ReadLine();
        }while(repeat=="yes");
    }
}
