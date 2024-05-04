using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClassLibrary1.Context
{
    public class BookContextWrite : DbContext
    {
        public BookContextWrite(DbContextOptions<BookContextWrite> options) : base(options)
        {

        }

        public DbSet<BookEntity> Books { get; set; }
    }
}
