using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter time of athlete1");
        int time1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter time of athlete2");
        int time2=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter time of athlete3");
        int time3=int.Parse(Console.ReadLine());
        int second=time1+time2+time3;
        int minutes=second/60;
        int seconds=second%10;
        string minutesString=(minutes<10)?"0"+minutes:minutes.ToString();
        string secondsString=(seconds<10)?"0"+seconds:seconds.ToString();
        Console.WriteLine("Total Time: "+minutesString+":"+secondsString);
    }
}
