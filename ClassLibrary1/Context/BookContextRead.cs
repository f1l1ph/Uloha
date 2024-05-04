using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Context
{
    public class BookContextRead : DbContext
    {
        public BookContextRead(DbContextOptions<BookContextRead> options) : base(options)
        {

        }

        public DbSet<BookEntity> Books { get; set; }
    }
}
