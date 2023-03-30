using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number between 0-100:");
        int number=int.Parse(Console.ReadLine());
        if(number<0||number>100)
        {
            Console.Write("Invalid input");
        }
        string[] ones={"zero","one","two","three","four","five","six","seven","eight","nine"};
        string [] tens={"ten","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
        string [] teens={"eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
        if(number==100)
        {
            Console.Write("Hundred");
        }
        else if(number>=90)
        {
            Console.Write(tens[8]);
            if(number%10!=0)
            {
                Console.Write("-"+ones[number%10]);
            }
        }
        else if(number>=80)
        {
           Console.Write(tens[7]);
           if(number%10!=0)
           {
            Console.Write("-"+ones[number%10]);
           }
        }
        else if(number>=70)
        {
           Console.Write(tens[6]);
           if(number%10!=0)
           {
            Console.Write("-"+ones[number%10]);
           }
        }
        else if(number>=60)
        {
           Console.Write(tens[5]);
           if(number%10!=0)
           {
            Console.Write("-"+ones[number%10]);
           }
        }
        else if(number>=50)
        {
           Console.Write(tens[4]);
           if(number%10!=0)
           {
            Console.Write("-"+ones[number%10]);
           }
        }
        else if(number>=40)
        {
           Console.Write(tens[3]);
           if(number%10!=0)
           {
            Console.Write("-"+ones[number%10]);
           }
        }
        else if(number>=30)
        {
           Console.Write(tens[2]);
           if(number%10!=0)
           {
            Console.Write("-"+ones[number%10]);
           }
        }
        else if(number>=20)
        {
           Console.Write(tens[1]);
           if(number%10!=0)
           {
            Console.Write("-"+ones[number%10]);
           }
        }
        else if(number>=11)
        {
           Console.Write(teens[number-11]);
        }
        else if(number==10)
        {
            
            Console.Write(tens[0]);
        }
        else
        {
            Console.Write(ones[number]);
        }
        
    }
}
