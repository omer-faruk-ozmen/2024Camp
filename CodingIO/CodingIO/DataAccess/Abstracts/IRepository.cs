using CodingIO.Entities;

namespace CodingIO.DataAccess.Abstracts;

public interface IRepository<T> where T:BaseEntity
{
    List<T> GetAll();
    Task<List<T>> GetAllAsync();

    T Get(Guid id);
    Task<T> GetAsync(Guid id);

    Guid Add(T entity);
    Task<Guid> AddAsync(T entity);

    bool Delete(Guid id);
    Task<bool> DeleteAsync(Guid id);

    Guid Update(T entity);
    Task<Guid> UpdateAsync(T entity);
}