using EmployeeDemo;

public class Program
{
    public static void Main(string [ ]args)
    {

        Console.Write("Enter Basic Salary: ");
        double empsalary = Convert.ToDouble(Console.ReadLine());  

        Console.WriteLine("Enter the total sales =");
        double sales=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Commision =");
        double commision=Convert.ToDouble(Console.ReadLine());



        SalesEmployee s1=new SalesEmployee(empsalary,sales,commision);

        Double Salary= s1.CalculateSalary();

        Console.WriteLine($"Complete sallary = {Salary}");

    }
}