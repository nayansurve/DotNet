namespace partialclassDemo;
public partial class BankAccount
{
    
    public void Deposite(decimal amount)
    {
        Balance=Balance + amount;
        Console.WriteLine($"{Name} Deposited {amount} new balance {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if(Balance >= amount)
        {
            Balance=Balance-amount;
            Console.WriteLine($"{Name} withdraw {amount} new balance {Balance}");
        }
        else
        {
            Console.WriteLine("Fund is InSufficeint");
        }
    }

    public void ApplyInterest(decimal rate)
    {
        Balance= Balance + Balance *rate;
        Console.WriteLine($"interest applied to {Name} account . new balance {Balance}");
    }
}