using HrApp;
using HrAPp;

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new SalesEmployee(101, "Sarthak", 50000, 70000);

        Employee emp2 = new SalesManager(102, "Naina", 40000, 600000, 300000);

        Console.WriteLine("Sales Employee");
        emp1.DoWork();
        Console.WriteLine("Salary" + emp1.ComputePay());

        Console.WriteLine();

        Console.WriteLine("Sales Manager");
        emp2.DoWork();
        Console.WriteLine("Salary = " + emp2.ComputePay());

    }
}