using System.Runtime.CompilerServices;

namespace Banking;
public class Account
{
    private double balance;

    public double GetBalance()
    {
        return balance;
    }
    public void SetBalance(double amount)
    {
        if(amount >=0)
        {
            balance=amount;
        }
        else
        {
            Console.WriteLine("balance cannot be negative ");
        }
    }
    public void Deposite(double amount)
    {
        if(amount > 0)
        {
            balance=balance+amount;
            Console.WriteLine($"Deposited :{amount:C}.new balance: {balance:c}");
        }
        else
        {
            Console.WriteLine("Deposite amount must be positive ");
        }
    }
    public void Withdraw(double amount)
    {
        if(amount > 0 && amount <=balance)
        {
            balance=balance-amount;
            Console.WriteLine($"Withdraw : {amount:C}.new balance : {balance:C}");
        }
        
    }
}
