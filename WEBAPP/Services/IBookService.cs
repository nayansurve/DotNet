using BookApi.Model;
using BookRepo.Repositories;
namespace BookServices.Services;


public interface IBookService
{
   List<Book> GetAllBook();

   Book GetBookById(int id);

   void AddBook(Book book);


}