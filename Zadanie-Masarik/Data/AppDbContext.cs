using Microsoft.EntityFrameworkCore;

namespace Zadanie_Masarik.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    
    public DbSet<Book> Books { get; set; }
}
