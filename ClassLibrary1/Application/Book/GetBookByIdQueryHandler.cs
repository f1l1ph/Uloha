using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Entities;
using ClassLibrary1.Repositories;
using MediatR;

namespace ClassLibrary1.Application.Book
{
    public class GetBookByIdQueryHandler(IBookRepositoryRead bookRepository):IRequestHandler<GetBookByIdQuery, BookEntity>
    {
        public Task<BookEntity> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            return bookRepository.GetById(request.Id);
        }
    }
}
