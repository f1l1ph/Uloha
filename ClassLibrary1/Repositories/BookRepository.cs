using ClassLibrary1.Context;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Repositories
{
    public class BookRepository(BookContext context) : IBookRepository
    {
        public async Task<IEnumerable<BookEntity>> GetAll()
        {
            var books = await context.Books.ToListAsync();

            return books;
        }

        public async Task<BookEntity> GetById(int id)
        {
            return await context.Books
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> Add(BookEntity book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();

            return book.Id;
        }

        public async Task Update(BookEntity book)
        {
            var dbBook = await GetById(book.Id);

            dbBook.Author = book.Author;
            dbBook.Title = book.Title;
            dbBook.Id = book.Id;

            var changesSaved = await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var dbBook = await GetById(id);

            context.Books.Remove(dbBook);
            var changesSaved = await context.SaveChangesAsync();
        }
    }
}
