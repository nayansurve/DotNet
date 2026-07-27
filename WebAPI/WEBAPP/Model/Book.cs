using Microsoft.AspNetCore.SignalR;

namespace BookApi.Model;

public class Book
{
   
     
    public int id {get; set;}
    public string name { get; set;}

    public string title {get; set;}

    public string auther {get;set; }

    public double price {get; set;}

}
