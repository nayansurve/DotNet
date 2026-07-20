namespace BookApp;

public class Book
{

  public int BookId{get;set;}
  public string Title{get;set;}
 // public string Author {get;set;}
  public double Price {get;set;}

  public Book(int bookid,string title, double price)
    {
        this.BookId=bookid;
        this.Title=title;
      //  this.Author=author;
        this.Price=price;

    }


}