using Inheritance;

public class Program
{
    public static void Main(string []args)
    {
        Manager m1=new Manager();
        double inr= m1.CalculateIncentive();
        double salary=m1.CalculateSalary();

        Console.WriteLine($"Salary With Incentive = {inr}");
        Console.WriteLine($"total salary = {salary}");

    }
}