namespace SimpleHelloAPP;

public class Program
{
  public static void Main(string [] args)
    {
        Console.WriteLine("Hello DotNet !!!");
        Console.WriteLine("Enter Name = ");
        string input=Console.ReadLine();
        Console.WriteLine($"You Entered : {input}");
    }
}