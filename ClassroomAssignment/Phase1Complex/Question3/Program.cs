using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Name1: ");
        string name1=Console.ReadLine().ToLower();
        Console.WriteLine("Name2: ");
        string name2=Console.ReadLine().ToLower();
        char [] character1=name1.ToCharArray();
        char [] character2=name2.ToCharArray();
        Array.Sort(character1);
        Array.Sort(character2);
        string word1=character1.ToString();
        string word2=character2.ToString();
        if(word1.Equals(word2))
        {
         Console.WriteLine("Anagram");
        }
        else
        {
            Console.WriteLine("Not Anagram");
        }
    }
}
