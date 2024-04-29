using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Zadanie_Masarik.Data;

namespace Zadanie_Masarik.Services;

public class BookService(AppDbContext context)
{
    #region create
    public async Task<Book?> AddBook(Book book)
    {
        context.Books.Add(book);
        var changesSaved = await context.SaveChangesAsync();

        return changesSaved > 0 ? book : null;
    }
    #endregion

    #region read
    public async Task<Book?> GetBookById(int id)
    {
        var book = await context.Books
            .FirstOrDefaultAsync(b => b.Id == id);

        return book;
    }

    public async Task<IEnumerable<Book>> GetBooks()
    {
        var books = await context.Books.ToListAsync();

        return books;
    }
    #endregion

    #region update
    public async Task<Book?> UpdateBook(int id, Book book)
    {
        var dbBook = await GetBookById(id);
        
        dbBook.Author = book.Author;
        dbBook.Title = book.Title;
        dbBook.Id = id;

        var changesSaved = await context.SaveChangesAsync();

        return changesSaved > 0 ? dbBook : null;
    }
    #endregion

    #region delete
    public async Task<bool> DeleteBookById(int id)
    {
        var dbBook = await GetBookById(id);

        if (dbBook == null) { return false; }

        context.Books.Remove(dbBook);
        var changesSaved = await context.SaveChangesAsync();
        return changesSaved > 0;
    }
    #endregion
}

