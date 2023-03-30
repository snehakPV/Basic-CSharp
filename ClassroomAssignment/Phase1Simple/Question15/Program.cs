using System;
namespace Question15;
class Program
{
    public static void Main(string[] args)
    
    {
        Console.WriteLine("Enter the name: ");
        string name=Console.ReadLine();
        getName(name);
        greet();
    }
    static void getName(string name)
    {
     Console.WriteLine("Welcome "+name);
    }
    static void greet()
    {
        Console.WriteLine("Have a nice day!");
    }
}
