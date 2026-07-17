using BookApi.Model;

namespace BookRepo.Repositories;

public interface IBookRepository
{
    List<Book>GetAll();

    Book GetById(int id);

    void Add(Book book);
}