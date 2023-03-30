using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Character: ");
        char Character=char.Parse(Console.ReadLine());
        switch(Character)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            {
                Console.WriteLine("Vowel");
                break;
            }
            default:
            {
                Console.WriteLine("Not a Vowel");
                break;
            }

        }
    }
}
