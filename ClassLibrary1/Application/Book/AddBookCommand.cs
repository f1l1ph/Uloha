using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class AddBookCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
