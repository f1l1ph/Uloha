using ClassLibrary1.Entities;

namespace ClassLibrary1.Repositories
{
    public interface IBookRepositoryRead
    {
        Task<IEnumerable<BookEntity>> GetAll();
        Task<BookEntity> GetById(int id);
    }
}
