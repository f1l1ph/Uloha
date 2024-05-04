using ClassLibrary1.Entities;

namespace ClassLibrary1.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookEntity>> GetAll();
        Task<BookEntity> GetById(int id);
        Task<int> Add(BookEntity product);
        Task<int> Update(BookEntity product);
        Task<int> Delete(int id);
    }
}