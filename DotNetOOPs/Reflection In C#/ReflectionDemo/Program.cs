using System.Reflection;
using ReflectionDemo;


public class Program
{
    public static void Main(string []args)
    {
        Simple s=new Simple();

        Type type=s.GetType();

        Console.WriteLine(type);
         int number = 50;

        Type t = number.GetType();

        Console.WriteLine(t);
    }
}