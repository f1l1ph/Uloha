using ClassLibrary1.Context;
using ClassLibrary1.Repositories;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Application.Book;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddBookCommand).Assembly));

builder.Services.AddTransient<IBookRepositoryWrite, BookRepositoryWrite>();
builder.Services.AddTransient<IBookRepositoryRead, BookRepositoryRead>();

builder.Services.AddDbContext<BookContextWrite>(// context for write db
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("db")));

builder.Services.AddDbContext<BookContextRead>(// context for read db
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("db")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
