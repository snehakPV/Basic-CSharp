using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the character: ");
        char character=char.Parse(Console.ReadLine());
        if(character=='a'||character=='e'||character=='i'||character=='o'||character=='u')
        {
         Console.WriteLine("It is a vowel");
        }
        else
        Console.WriteLine("It is not a vowel");
    }
}
