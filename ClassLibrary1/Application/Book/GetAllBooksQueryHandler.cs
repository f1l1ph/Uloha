using ClassLibrary1.Entities;
using ClassLibrary1.Repositories;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class GetAllBooksQueryHandler(IBookRepository bookRepository) : IRequestHandler<GetAllBooksQuery, IEnumerable<BookEntity>>
    {
        public async Task<IEnumerable<BookEntity>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await bookRepository.GetAll();
        }
    }
}
