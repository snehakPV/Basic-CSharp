using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your DOB: ");
        DateTime Dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime Date=DateTime.Now;
        TimeSpan span=Date-Dob;
        Console.WriteLine($"Age= {(int)span.TotalDays/365} and day you were born on: {Dob.DayOfWeek}");
        Console.WriteLine("Age in days,hours,minutes,seconds and milliseconds is: ");
        Console.WriteLine($"Days:{(int)span.TotalDays},Hours:{(int)span.TotalHours},minutes:{(int)span.TotalMinutes},seconds:{(int)span.TotalSeconds},millisecond:{(int)span.TotalMilliseconds}");
    }}
