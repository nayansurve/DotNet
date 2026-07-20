using InterfaceDemo;

public class Program
{
    public static void Main(string [] args)
    {
        Transcation txn=new Transcation();

        IOrderDetails order=txn;
        order.ShowDetails();

        ICustomerDetails customer=txn;
        customer.ShowDetails();
    }
}
