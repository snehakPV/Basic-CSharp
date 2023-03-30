using System;
namespace Question1;
class Program
{
public static void Main(string[] args)
{
    string name=Console.ReadLine();
    Console.WriteLine("Hello:");
    Console.WriteLine(name);
    Console.WriteLine("Hello:");
    Console.WriteLine("{0}",name);
    Console.WriteLine("Hello:");
    Console.WriteLine($"{name}");
}    
}