using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int value1=15,value2=20;
        bool result1=value1>value2?true:false;
        bool result2=value1<value2?true:false;
        bool result3=value1>=value2?true:false;
        bool result4=value1==value2?true:false;
        bool result5=value1!=value2?true:false;
        bool result6=value1<=value2?true:false;
        bool result7=((value1>=10)&&(value2>=10))?true:false;
        bool result8=((value1>=10)||(value2>=30))?true:false;
        bool result9=!(value1>20)?true:false;
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.WriteLine(result6);
        Console.WriteLine(result7);
        Console.WriteLine(result8);
        Console.WriteLine(result9);


    }
}
