using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;



namespace CompareInterfaceDemo;

public class Manager :IComparer<Employee>

{
    public int Compare(Employee x, Employee y)
    {
        return x.Name.CompareTo(y.Name);
    }
}