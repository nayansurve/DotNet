using Entities;

namespace Service;


public class ProductService
{
        public static List<Product> GetAll(){
        List<Product> products=new List<Product>();

        products.Add(new Product{Id=101,Name="Rose",Price=7.6});
        products.Add(new Product{Id=102,Name="Tulip",Price=1.1});
        products.Add(new Product{Id=103,Name="Gerbera",Price=4.4});
        products.Add(new Product{Id=104,Name="Carntia",Price=6.6});
        return products;
}


         public static string Insert()
    {
        Console.WriteLine("New Product Added Successfully");
        return "Product Added Suceessfully";
    } 

}
