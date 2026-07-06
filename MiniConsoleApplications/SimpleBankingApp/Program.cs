using Banking;

public class Program
{
    public static void Main(string[] args)
    {
        Account ac = new Account();
        Console.WriteLine("Please Set your Balance = ");
        double initialBalance = Convert.ToDouble(Console.ReadLine());
        ac.SetBalance(initialBalance);
        Console.WriteLine("Please enter the deposite = ");
        double newDeposite=Convert.ToDouble(Console.ReadLine());
        ac.Deposite(newDeposite);
        Console.WriteLine("Enter the amount which you want to withdraw = ");
        double newWithdraw=Convert.ToDouble(Console.ReadLine());
        ac.Withdraw(newWithdraw);
        Console.WriteLine("Your Current Balance is = ");
        double currentBalance =ac.GetBalance();
      Console.WriteLine($"Current Balane : {currentBalance:C}");

    }
}