﻿using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        DateTime []dateTime={ DateTime.Now,new DateTime(2016,8,16,9,28,0),new DateTime(2011,5,28,10,35,0),new DateTime(1979,12,25,14,30,0) };
        foreach(DateTime dateTime1 in dateTime)
        {
            System.Console.WriteLine(dateTime1.ToString("HH:mm:ss"));
        }
    }
}