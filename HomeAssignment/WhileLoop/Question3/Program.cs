using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        int multiple=5;
        while(multiple<=number)
        {
            {
             Console.WriteLine(multiple);
             multiple+=5;
            }
        }
    }
}