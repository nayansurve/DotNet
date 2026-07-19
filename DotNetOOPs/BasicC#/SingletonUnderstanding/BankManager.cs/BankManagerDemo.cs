namespace BankApp;

public sealed class BankManagerDemo
{
    private static BankManagerDemo? _instance=null;


    private BankManagerDemo()
    {
        //private constructor
    }

    public static BankManagerDemo Instance
    {
        get
        {
            if(_instance == null)
            {
               _instance=new BankManagerDemo();
            }
            return _instance;
        }
    }
    public void ApproveLoan(decimal amount)
    {
        Console.WriteLine($"{amount}  Loan Approved By the Bank Manager");
    }

}