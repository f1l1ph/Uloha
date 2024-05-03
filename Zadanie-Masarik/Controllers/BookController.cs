using ClassLibrary1.Application.Book;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Zadanie_Masarik.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController(IMediator mediator) : Controller
{
    #region create
    [HttpPost("AddBook")]
    public async Task<IActionResult> AddBook(AddBookCommand command)
    {
        var bookId = await mediator.Send(command);
        return Ok(bookId);
    }
    #endregion
    /*
    #region read
    [HttpGet($"GetBook/{{id:int}}")]
    public async Task<Book?> GetById(int id)
    {
        return await bookService.GetBookById(id);
    }

    [HttpGet($"GetBooks/")]
    public async Task<IEnumerable<Book>> GetBooks()
    {
        return await bookService.GetBooks();
    }
    #endregion

    #region update
    [HttpPost($"UpdateBook/{{id:int}}")]
    public async Task<Book?> UpdateBook(int id, Book book)
    {
        return await bookService.UpdateBook(id, book);
    }
    #endregion

    #region delete
    [HttpDelete($"DeleteBook/{{id:int}}")]
    public async Task<bool> DeleteBookById(int id)
    {
        return await bookService.DeleteBookById(id);
    }
    #endregion*/
}