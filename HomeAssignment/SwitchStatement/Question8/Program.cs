using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the month: ");
        string month=Console.ReadLine();
        switch(month)
        {
         case "December":
         case "January":
         case "February":
         {
          Console.WriteLine("Winter");
          break;
         }
         case "March":
         case "April":
         case "May":
         {
          Console.WriteLine("Spring");
          break;
         }
         case "June":
         case "July":
         case "August":
         {
          Console.WriteLine("Summer");
          break;
         }
         case "September":
         case "October":
         case "November":
         {
          Console.WriteLine("Rainfall");
          break;
         }
        }
    }
}