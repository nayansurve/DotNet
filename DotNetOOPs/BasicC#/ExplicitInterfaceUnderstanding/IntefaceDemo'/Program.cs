using InterfaceDemo;
using CollectionDemo;
public class Program
{
    public static void Main(string [] args)
    {
        Transcation txn=new Transcation();

        IOrderDetails order=txn;
        order.ShowDetails();

        ICustomerDetails customer=txn;
        customer.ShowDetails();


        var myData = new MyCustomCollection();
foreach (int num in myData)
{
    Console.WriteLine(num);
}
    }
}
