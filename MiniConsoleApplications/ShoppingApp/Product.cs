namespace Ecommerse;

public class Product
{
    
    private string product_name;
    private decimal Price;

    private int Quantity;

    public Product(string pr_nm, decimal price,int quantity )
    {
        this.product_name=pr_nm;
        this.Price=price;
        this.Quantity=quantity;
    }

    public string GetProductName()
    {
         return product_name;
    }
    public  decimal GetPrice()
    {
        return Price;
    }
    public int GetQuantity()
    {
        return Quantity;
    }

    public void Display()
    {
        Console.WriteLine($"Product Name : {product_name}.Price : {Price:C}.Quantity : {Quantity}");
    }

}