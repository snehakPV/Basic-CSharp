using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value=Convert.ToInt32(Console.ReadLine());
        bool result1=value==15?true:false;
        Console.WriteLine(result1);
        bool result2=value<=5?true:false;
        Console.WriteLine(result2);
    }
}
