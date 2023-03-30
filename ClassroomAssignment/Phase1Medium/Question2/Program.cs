using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        double N=double.Parse(Console.ReadLine());
        double W=double.Parse(Console.ReadLine());
        double L=double.Parse(Console.ReadLine());
        double M=double.Parse(Console.ReadLine());
        double O=double.Parse(Console.ReadLine());
        double areaGround=N*N;
        double areaBench=M*O;
        double areaTile=W*L;
        double tilesNeeded=(areaGround-areaBench)/areaTile;
        double totalTime=tilesNeeded*0.2;
        System.Console.WriteLine(Math.Ceiling(tilesNeeded));
        System.Console.WriteLine(totalTime);
    }
}