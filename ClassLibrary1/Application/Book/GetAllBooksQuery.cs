using ClassLibrary1.Entities;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class GetAllBooksQuery : IRequest<IEnumerable<BookEntity>>
    {

    }
}
