using ClassLibrary1.Context;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Repositories
{
    public class BookRepositoryWrite(BookContextWrite contextWrite) : IBookRepositoryWrite
    {
        /*public async Task<IEnumerable<BookEntity>> GetAll()
        {
            return await contextWrite.Books.ToListAsync();
        }

        public async Task<BookEntity> GetById(int id)
        {
            return await contextWrite.Books
                .FirstOrDefaultAsync(b => b.Id == id);
        }*/

        public async Task<int> Add(BookEntity book)
        {
            contextWrite.Books.Add(book);
            await contextWrite.SaveChangesAsync();

            return book.Id;
        }

        public async Task<int> Update(BookEntity book)
        {
            var dbBook = await contextWrite.Books
                .FirstOrDefaultAsync(b => b.Id == book.Id); ;

            if (dbBook != null)
            {
                dbBook.Author = book.Author;
                dbBook.Title = book.Title;
                dbBook.Id = book.Id;
            }

            var changesSaved = await contextWrite.SaveChangesAsync();
            return book.Id;
        }

        public async Task<int> Delete(int id)
        {
            var dbBook = await contextWrite.Books
                .FirstOrDefaultAsync(b => b.Id == id); ;

            if (dbBook != null) contextWrite.Books.Remove(dbBook);
            var changesSaved = await contextWrite.SaveChangesAsync();
            return id;
        }
    }
}
