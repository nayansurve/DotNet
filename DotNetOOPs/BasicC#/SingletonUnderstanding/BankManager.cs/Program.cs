using BankApp;

public class Program
{
    public static void Main(string [] args)
    {
        BankManagerDemo m1=BankManagerDemo.Instance;

        BankManagerDemo m2=BankManagerDemo.Instance;

        m1.ApproveLoan(5000);

        Console.WriteLine(Object.ReferenceEquals(m1,m2));

        
    }
}