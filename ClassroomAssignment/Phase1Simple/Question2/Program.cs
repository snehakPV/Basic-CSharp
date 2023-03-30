using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        
        double basicSalary=10000;
        double tax=0.05;
        double da=0.1*basicSalary;
        double hra=0.1*basicSalary;
        double grossSalary=basicSalary+da+hra;
        double annualSalary=12*grossSalary;
        double taxs=tax*annualSalary;
        double annualIncome=annualSalary-taxs;
        Console.WriteLine("Annual Income= "+annualIncome);
    }
}
