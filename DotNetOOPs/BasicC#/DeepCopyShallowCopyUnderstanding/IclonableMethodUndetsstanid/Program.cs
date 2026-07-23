using System.Runtime.CompilerServices;
using Demo;

public class Program
{
    public static void Main(string [] args)
    {
        Person p1=new Person{Name="Amit",Age=30};
        Person clone=(Person)p1.Clone();

        Console.WriteLine(clone.Name);
        Console.WriteLine(clone.Age);
    }
}