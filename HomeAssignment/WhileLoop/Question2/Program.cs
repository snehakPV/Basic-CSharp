using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string option="";
        while(true)
        {
        Console.WriteLine("Enter your name: ");
        string name=Console.ReadLine();
        Console.WriteLine("Welcome "+name);
        Console.WriteLine("Do you want to continue? (yes/no)");
        option=Console.ReadLine();
        if(option=="no")
        {
            break;
        }
        }
    }
}
