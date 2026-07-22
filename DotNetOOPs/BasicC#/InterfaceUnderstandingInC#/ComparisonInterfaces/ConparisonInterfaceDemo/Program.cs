using CompareInterfaceDemo;

public class Program
{
    public static void Main(string [] args)
    {
        List <Employee> employees =new List<Employee>()
        {
            new Employee{Name="Naina",Salary=100000},
            new Employee{Name="Sarthak",Salary=80000},
            new Employee{Name="Shriyansh",Salary=70000}     
        };

          Console.WriteLine("Compare By Salary {IComparable}");
          employees.Sort();

          foreach(Employee e in employees)
        {
            Console.WriteLine($"{e.Name} - {e.Salary}");
        }

        Console.WriteLine();
        Console.WriteLine("comparison using ICoparator");

           employees.Sort(new Manager());

        foreach(Employee e in employees)
        {
            Console.WriteLine($"{e.Name} - {e.Salary}");
        }
    }
}