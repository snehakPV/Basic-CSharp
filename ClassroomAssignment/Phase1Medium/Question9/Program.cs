using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the date(dd/MM/yyyy): ");
        DateTime date=DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of months: ");
        int month=int.Parse(Console.ReadLine());
        Calculation(date,month);

    }
    static void Calculation(DateTime date,int month)
    {
      DateTime Calculate=date.AddMonths(month);
      Console.WriteLine(Calculate);
    }
    
}
