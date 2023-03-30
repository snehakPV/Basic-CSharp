using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string words=Console.ReadLine();
        char [] characters=words.ToCharArray();
        string string1="";
        for(int i=0;i<characters.Length;i++)
        {
         
            if(!string1.Contains(characters[i]))
            {
                string1+=characters[i];
            }
         
        }
        Console.Write(string1);

    }
}

