using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Zadanie_Masarik.Data;
using Zadanie_Masarik.Services;

namespace Zadanie_Masarik.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController(BookService bookService) : Controller
{
    #region create
    [HttpPost("AddBook")]
    public async Task<Book?> AddBook(Book book)
    {
        return await bookService.AddBook(book);
    }
    #endregion

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
    #endregion
}