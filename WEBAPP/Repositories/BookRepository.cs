using BookApi.Model;

namespace BookRepo.Repositories;

public class BookRepository:IBookRepository
{
    private static List<Book> books=new List<Book>
    {
        new Book
        {
            id=1,
            name="ASP .Net",
            auther="xyz",
            title="OOpsConcept",
            price=110.00
        },

        new Book
        {
            id =2,
            name ="Java",
            auther="lmn",
            title="Spring Boot",
            price=220.0
        }

    };

    public List<Book>GetAll()
    {
        return books;
    }

    public Book GetById(int id)
    {
        return books.FirstOrDefault(x => x.id == id);
    }

    public void Add(Book book)
         {
             books.Add(book);
          
           }


}