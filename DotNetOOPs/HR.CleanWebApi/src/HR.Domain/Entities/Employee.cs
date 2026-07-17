using System.Dynamic;

namespace HR.Domain.Entities;

public abstract class Employee
{
    public int empId {get;set;}

    public string empName{get;set;}

    public double empSalary{get;set;}

    public string empLocation{get;set;}

    public abstract double CalculateSalary();
}