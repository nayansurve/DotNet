namespace MulticastDemo;

delegate void MulticastDeleagte();
public class Employee
{
    public void Hello()
    {
        Console.WriteLine("Hello Method Called");

    }
    public void WelCome()
    {
        Console.WriteLine("Welcome Method Called");
    }

    public void GoodBye()
    {
        Console.WriteLine("GoodBye Method Called");
    }
}