using System;
namespace Question14;
class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Enter the string: ");
    string word=Console.ReadLine();
    char []characters=word.ToCharArray();
    int count=0;
    for(int i=0;i<characters.Length;i++)
    {
        if( characters[i] == 'a'||characters[i] == 'e'||characters[i] == 'i'||characters[i] == 'o'||characters[i] == 'u')
        {
          count++;
        }

    }
    Console.WriteLine("The total number vowels in a string= "+count);
}
}