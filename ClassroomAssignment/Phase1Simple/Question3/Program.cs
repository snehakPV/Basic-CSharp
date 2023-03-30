using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        string password="s3cr3t!P@ssw0rd";
        Console.WriteLine("Enter the password: ");
        string word=Console.ReadLine();
        if(password==word)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong Password!");
        }

    }
}
