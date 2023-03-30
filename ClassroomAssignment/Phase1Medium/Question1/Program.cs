using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter basic salary:");
        double basicSalary=double.Parse(Console.ReadLine());
        double hra,da;
        if(basicSalary<=10000)
        {
            hra=0.2*basicSalary;
            da=0.8*basicSalary;
        }
        else if(basicSalary <= 20000)
        {
            hra=0.25*basicSalary;
            da=0.9*basicSalary;
        }
        else
        {
            hra=0.3*basicSalary;
            da=0.95*basicSalary;
        }
        double grossSalary=basicSalary+hra+da;
        double tax=0.06*grossSalary;
        double insurance=0.01*grossSalary;
        double takeHomeSalary=grossSalary-tax-insurance;
        System.Console.WriteLine("Gross Salary:"+grossSalary);
        System.Console.WriteLine("Take-Home Salary:"+takeHomeSalary);
    }
}