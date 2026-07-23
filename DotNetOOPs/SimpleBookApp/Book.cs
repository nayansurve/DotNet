namespace BookDemo;
using System.Collections;

public class Book : IEnumerable
{
  public  int Id {get; set;}

  public string Name{get;set;}

  public Book(int id,string name)
    {
        Id=id;
        Name=name;
    }

    public void Display()
    {
        Console.WriteLine($"Details of Book");
        
        Console.WriteLine($"Book id is :{Id} Book Name Is: {Name}");

    }
    
}