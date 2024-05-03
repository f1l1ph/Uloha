using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class DeleteBookCommandHandler:IRequestHandler<DeleteBookCommand, int>
    {
        public async Task<int> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
