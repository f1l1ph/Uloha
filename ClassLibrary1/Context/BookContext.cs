using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClassLibrary1.Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<BookEntity> Books { get; set; }
    }
}
