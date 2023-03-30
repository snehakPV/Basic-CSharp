using System;
namespace Question6;
class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter the temperature");
    int temperature=int.Parse(Console.ReadLine());
    if(temperature<0)
    {
        Console.WriteLine("Freezing Weather");
    }
    else if(temperature>=0&&temperature<=10)
    {
        Console.WriteLine("very Cold weather");
    }
    else if(temperature>10&&temperature<=20)
    {
        Console.WriteLine("Cold weather");
    }
    else if(temperature>20&&temperature<=30)
    {
        Console.WriteLine("Normal temperature");
    }
    else if(temperature>30&&temperature<=40)
    {
        Console.WriteLine("Its Hot");
    }
    else
    {
        Console.WriteLine("Its very Hot");
    }
  }
}
