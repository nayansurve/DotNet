using System.Reflection.Metadata.Ecma335;
using partialclassDemo;

public class Program
{
    public static void Main(string [] args)
    {
        BankAccount b1=new BankAccount()
        {
            Account_Number=101,
        Name="Naina",
        Balance=2000

        };
      
        
        b1.Deposite(200);
        b1.Withdraw(1000);
        b1.ApplyInterest(0.05m);
    }
}