using BookApi.Model;
using BookRepo.Repositories;
namespace BookServices.Services;


public class BookService:IBookService
{
    private readonly  IBookRepository _repository;

    public BookService(IBookRepository repository)
    {
        _repository=repository;
    }

    public List<Book> GetAllBook()
    {
        return _repository.GetAll();
    
    }

    public Book GetBookById(int id)
    {
        return _repository.GetById(id);
    }

    public void AddBook(Book book)
    {
        _repository.Add(book);
    }
}