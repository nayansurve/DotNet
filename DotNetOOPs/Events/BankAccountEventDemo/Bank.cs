using System.Runtime;

namespace BankEventDemo;

public delegate void BankOperation();
public class Bank
{
     private int Balance;
    public event BankOperation? OverBalance;
    public event BankOperation? UnderBalance;


   public Bank(int amount)
    {
        this.Balance=amount;
    }

    public void Deposite(int amount)
    {
        Balance=Balance+amount;
        if(amount > 100000)
        {
            OverBalance?.Invoke(); //Raise OverBalanceEvent
        }
    }

    public void Withdraw(int amount)
    {
        Balance=Balance-amount;

        if(Balance <5000)
        {
            UnderBalance?.Invoke(); //Raise UnderBalance Event
        }
    }

}