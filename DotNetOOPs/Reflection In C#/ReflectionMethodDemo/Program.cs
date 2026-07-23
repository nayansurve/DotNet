using DemoApp;
using System.Reflection;
public class Program
{
    public static void Main (string[]args)
    {
        Demo d=new Demo();

        Type type=d.GetType();

        var methods=type.GetMethods();

        foreach(var method in methods)
        {
            Console.WriteLine(method.Name);
        }
        
    }
}