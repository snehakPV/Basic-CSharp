using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
     string correctAnswer="c";
     string userAnswer;
     char continueAnswer;
     do
     {
      Console.WriteLine("What is the command keyword to exit a loop in C#? ");
      Console.WriteLine("a.int");
      Console.WriteLine("b.continue");
      Console.WriteLine("c.break");
      Console.WriteLine("d.exit");
      Console.WriteLine("Enter your choice: ");
      userAnswer=Console.ReadLine();
      if(userAnswer==correctAnswer)
      {
        Console.WriteLine("Correct");
        break;
      }
      else
      {
        Console.WriteLine("Incorrect");
        Console.WriteLine("Try Again? press y to continue: ");
        continueAnswer=Console.ReadKey().KeyChar;
      }
     }while(continueAnswer=='y');
    }
}
