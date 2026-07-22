using System;

class Program
{
    static void Main()
    {
        Action<string> greet =
        delegate(string name)
        {
            Console.WriteLine("Hello " + name);
        };

        Func<int,int,int> add =
        delegate(int a,int b)
        {
            return a+b;
        };

        Predicate<int> even =
        delegate(int n)
        {
            return n%2==0;
        };

        greet("Nayan");

        Console.WriteLine(add(10,20));

        Console.WriteLine(even(10));
    }
}