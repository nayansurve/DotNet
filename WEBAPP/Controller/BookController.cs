using System.ComponentModel;
using System.Net.NetworkInformation;
using BookApi.Model;
using BookRepo.Repositories;
using BookServices.Services;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;

namespace BookController.Controller;
// {

[ApiController]
[Route("api/[Controller]")]

public class BookController :ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
          _bookService=bookService;
    }

    [HttpGet]

    public ActionResult<List<Book>>GetAll()
    {
        return  _bookService.GetAllBook();
    }

    

    [HttpGet("{id}")]

    public ActionResult<Book> GetById(int id )
    {
        return _bookService.GetBookById(id);
    }

    [HttpPost]

    public ActionResult Add(Book book)
    {
        _bookService.AddBook(book);
        return Ok ("Book Added Successfully");
    }
    
}

// }
