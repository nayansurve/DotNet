using CollectionDemo;

public class Program
{
    public static void Main(string [] args)
    {
        Product[] products=new Product[5]
        {
            
              new Product(101, "Mouse", 500),
              new Product(102, "Keyboard",700),
              new Product(103,"LAN",1000),
              new Product(104,"Laptop",2000),
              new Product(105,"Charger",4000),
        };
    

    
          Console.WriteLine($"Product Name : {products[0].Id}");
          Console.WriteLine($"Product name : {products[0].Name}");
          Console.WriteLine($"Product price : {products[0].Price}");
        


        

}
}