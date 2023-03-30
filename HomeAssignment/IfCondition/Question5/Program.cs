using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter age: ");
        decimal age=decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter gender(m/f):");
        char gender=char.Parse(Console.ReadLine());
        string title=string.Empty;
        if(gender=='m')
        {
            if(age>=16)
            {
                title="Master";
            }
        }
        else
        {
            if(age>=16)
            {
                title="Ms.";
            }
            else
            {
                title="Miss";
            }
        }
        Console.WriteLine("Personal title:"+title);
    }
}
