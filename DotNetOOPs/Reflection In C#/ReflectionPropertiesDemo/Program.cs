using Demoapp;
using System;

public  class Program
{
    public static void Main(string [] args)
    {
        Demo d=new Demo();

        Type type=d.GetType();

        var properties=type.GetProperties();
        Console.WriteLine("Properties Displayed By the Reflction In C#");

        foreach(var p in properties)
        {
        Console.WriteLine(p.Name);
        }
    }
}