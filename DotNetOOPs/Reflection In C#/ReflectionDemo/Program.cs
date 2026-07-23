using System.Reflection;
using ReflectionDemo;


public class Program
{
    public static void Main(string []args)
    {
        Simple s=new Simple();

        Type type=s.GetType();

        Console.WriteLine(type);
    }
}