namespace CompareInterfaceDemo;

public class Employee : IComparable<Employee>
{
    public string Name {get;set;}
    public int Salary {get; set;}

    public int CompareTo(Employee other)
    {
        return Salary.CompareTo(other.Salary);
    }
}