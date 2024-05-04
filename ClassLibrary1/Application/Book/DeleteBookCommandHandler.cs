using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Repositories;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class DeleteBookCommandHandler(IBookRepositoryWrite bookRepositoryWrite):IRequestHandler<DeleteBookCommand, int>
    {
        public async Task<int> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            return await bookRepositoryWrite.Delete(request.Id);
        }
    }
}
