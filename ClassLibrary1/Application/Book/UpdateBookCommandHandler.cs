using ClassLibrary1.Repositories;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class UpdateBookCommandHandler(IBookRepositoryWrite bookRepositoryWrite) : IRequestHandler<UpdateBookCommand, int>
    {
        public async Task<int> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Entities.BookEntity
            {
                Id = request.Id,
                Title = request.Title,
                Author = request.Author,
            };

            return await bookRepositoryWrite.Update(book);
        }
    }
}
