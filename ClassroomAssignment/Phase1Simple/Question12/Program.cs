using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the date (dd/MM/yyyy): ");
        DateTime date=DateTime.Parse(Console.ReadLine());
        Console.WriteLine("The day of the week for "+date+" is "+date.DayOfWeek);
    }
}