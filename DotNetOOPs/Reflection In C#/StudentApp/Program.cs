using System;
using System.Reflection;

class Student
{
    public string Name { get; set; } = "Nayan";

    public int Age { get; set; } = 22;

    public Student()
    {
    }

    public void Display()
    {
        Console.WriteLine("Welcome " + Name);
    }
}

class Program
{
    static void Main()
    {
        // Step 1: Create object
        Student student = new Student();

        // Step 2: Get type information
        Type type = student.GetType();

        Console.WriteLine("Class Name : " + type.Name);

        Console.WriteLine("\nProperties");

        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("\nMethods");

        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nConstructors");

        foreach (ConstructorInfo constructor in type.GetConstructors())
        {
            Console.WriteLine(constructor.Name);
            Console.WriteLine(type.Name);
        }
    }
}