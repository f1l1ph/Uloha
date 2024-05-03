using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class DeleteBookCommand: IRequest<int>
    {
        public int Id { get; set; }
    }
}
