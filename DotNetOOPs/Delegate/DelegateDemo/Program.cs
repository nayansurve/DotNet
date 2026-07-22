using System;
using DelegateDemo;

public class Program
{

    public static void Hello()
    {
        Console.WriteLine("Hellooo Everyone");
    }
    public static void Main(string[] args)
    {
        Employee e = new Employee(101, "Naina");

        MyDelagate del = e.Display;
        del();

        Console.WriteLine();
        del = Hello;

        del();

    }
}