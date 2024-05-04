using ClassLibrary1.Repositories;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class AddBookCommandHandler(IBookRepositoryWrite bookRepositoryWrite) : IRequestHandler<AddBookCommand, int>
    {
        public async Task<int> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Entities.BookEntity
            {
                Title = request.Title,
                Author = request.Author,
            };

            return await bookRepositoryWrite.Add(book);
        }
    }
}
