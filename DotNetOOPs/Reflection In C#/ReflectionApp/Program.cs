using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Change this path if your .NET version is different
      Assembly assembly = Assembly.LoadFile(
    @"C:\Users\sarth\OneDrive\Desktop\TAP_Git Nayana\DotNet\DotNetOOPs\Reflection In C#\Test\bin\Debug\net9.0\Test.dll");
        Type calcType = assembly.GetType("Test.Calculator");

        object calc = Activator.CreateInstance(calcType);

        PropertyInfo prop = calcType.GetProperty("Number");
        prop.SetValue(calc, 10.0);

        MethodInfo method = calcType.GetMethod("Add");

        double result =
            (double)method.Invoke(calc, new object[] { 5.0 });

        Console.WriteLine(result);
    }
}