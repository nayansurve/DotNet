
using System.ComponentModel;

public class StaticKeyword
{
    public static int Add(int a,int b)
    {
        return a+b;
    }

}

public class Program
{
    public static void Main(string [] args )
    {
         int result=StaticKeyword.Add(10,20);
         Console.WriteLine($"Addition = {result}");

    }

}