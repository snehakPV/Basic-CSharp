using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a string:");
        string word=Console.ReadLine();
        System.Console.WriteLine("Alphabet Count:"+Alphabet(word));
        System.Console.WriteLine("Digits Count:"+Digit(word));
        System.Console.WriteLine("Special Character Count:"+SpecialChars(word));
        
    }
    static int Alphabet(string word)
    {
        int count=0;
        foreach(char character in word)
        {
            if(char.IsLetter(character))
            {
                count++;
            }
        }
        return count;
    }
    static int Digit(string word)
    {
       int count=0;
        foreach(char character in word)
        {
            if(char.IsDigit(character))
            {
                count++;
            }
        }
        return count; 
    }
    static int SpecialChars(string word)
    {
        int count=0;
        foreach(char character in word)
        {
            if(!char.IsLetterOrDigit(character)&&!char.IsWhiteSpace(character))
            {
                count++;
            }
        }
        return count;
    }
}