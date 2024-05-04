using ClassLibrary1.Entities;
using ClassLibrary1.Context;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Repositories
{
    public class BookRepositoryRead(BookContextRead context) : IBookRepositoryRead
    {
        public async Task<IEnumerable<BookEntity>> GetAll()
        {
            return await context.Books.ToListAsync();
        }

        public async Task<BookEntity> GetById(int id)
        {
            return await context.Books
                .FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
