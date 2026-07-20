using BookApp;
using CollectionDemo;

public class Program
{
    public static void Main(string[] args)
    {
        Product[] products = new Product[5]
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

        Book[] books = new Book[5]
        {

              new Book(101, "java", 50.0),
              new Book(102, "C# basic",70),
              new Book(103,"Python",1000),
              new Book(104,"Data Structure",20),
              new Book(105,"Web Development",40),
        };

     Console.WriteLine($"Book Name = {books[0].Title}");






    }
}