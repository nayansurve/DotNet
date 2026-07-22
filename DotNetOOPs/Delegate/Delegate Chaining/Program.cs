using System.Buffers;
using ChainingDemo;

public class Program
{
    public static void Main(string [] args)
    {
        Calculator cal=new Calculator();

        CalDelegate add=cal.Add;

        CalDelegate sub=cal.Sub;

        CalDelegate combine;

        combine=(CalDelegate)Delegate.Combine(add,sub);
        
        Console.WriteLine("Combining two methods");   

        combine();

        combine=(CalDelegate)Delegate.Remove(combine,sub);
       // combine=(CalDelegate)Delegate.Remove(combine,add);

        Console.WriteLine("After Removing one method");

        combine();
    }
}