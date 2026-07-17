namespace EmployeeDemo;

public class Employee
{
    public double empBasicSalary;

     public Employee(double empsalary)
    {
         this.empBasicSalary=empsalary;
    }
    public double CalculateSalary()
    {
        return empBasicSalary;
    }
}

