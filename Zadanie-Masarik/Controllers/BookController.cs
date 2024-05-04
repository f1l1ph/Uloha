using ClassLibrary1.Application.Book;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Entities;

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
    
    #region read
    [HttpGet($"GetBook{{id:int}}")]
    public async Task<BookEntity?> GetById(int id)
    {
        return await mediator.Send(new GetBookByIdQuery(id));
    }

    [HttpGet("GetBooks")]
    public async Task<IEnumerable<BookEntity>> GetBooks()
    {
        return await mediator.Send(new GetAllBooksQuery());
    }
    #endregion
    
    #region update
    [HttpPost("UpdateBook")]
    public async Task<int> UpdateBook(UpdateBookCommand command)
    {
        return await mediator.Send(command);
    }
    #endregion
    
    #region delete
    [HttpDelete($"DeleteBook")]
    public async Task<IActionResult> DeleteBookById(DeleteBookCommand command)
    { 
        await mediator.Send(command);

        return Ok("Successfully deleted");
    }
    #endregion
}