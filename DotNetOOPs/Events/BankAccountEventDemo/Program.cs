using BankEventDemo;

public class Program
{
  
    public static void Main(string [] args)
    {
        Bank b=new Bank(15000);
        b.UnderBalance+=PayPenality;
        b.UnderBalance+=BlockAccount;
        b.OverBalance+=PayIncomeTax;
        b.OverBalance+=PayProfessionalTax;
         b.Withdraw(15000);
         b.Deposite(30000000);
    }       
          public static void PayPenality()
    {
        Console.WriteLine("Pay 500 As Per Penality");
    }
    static void BlockAccount()
    {
        Console.WriteLine("your Account has beed blocked");
    }

    static void PayIncomeTax()
    {
        Console.WriteLine("Please Pay Applicable Income Tax");
    }

    static void PayProfessionalTax()
    {
        Console.WriteLine("Professional Quarter Due This Quarter");
    }
    }
