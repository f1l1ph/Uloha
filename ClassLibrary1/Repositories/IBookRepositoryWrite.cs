using ClassLibrary1.Entities;

namespace ClassLibrary1.Repositories
{
    public interface IBookRepositoryWrite
    {
        Task<int> Add(BookEntity product);
        Task<int> Update(BookEntity product);
        Task<int> Delete(int id);
    }
}