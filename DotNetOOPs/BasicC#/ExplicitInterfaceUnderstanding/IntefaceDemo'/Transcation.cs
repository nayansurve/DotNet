namespace InterfaceDemo;

public class Transcation:IOrderDetails,ICustomerDetails
{

    void IOrderDetails.ShowDetails()
    {  
        Console.WriteLine("Customer Details");
        Console.WriteLine("Order Transaction Complete to Naina");
    }

    void ICustomerDetails.ShowDetails()
    {
        Console.WriteLine("Customer Details");
        Console.WriteLine("Name : Naina , City : Kolhapur");
    }
}