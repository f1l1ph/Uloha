using ClassLibrary1.Entities;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class GetBookByIdQuery(int id) : IRequest<BookEntity>
    {
        public int Id { get; set; } = id;
    }
}
