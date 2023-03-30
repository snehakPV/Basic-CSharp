using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string input=Console.ReadLine();
        char[] characters=input.ToCharArray();
        string reverse="";
        for(int i=characters.Length-1;i>=0;i--)
        {
          reverse+=characters[i];
        }
        Console.WriteLine("The characters of string in reverse : "+reverse);
    }
}
