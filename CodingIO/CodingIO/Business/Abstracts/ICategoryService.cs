using CodingIO.Entities;

namespace CodingIO.Business.Abstracts;

public interface ICategoryService
{
    List<Category> GetAll();
    Task<List<Category>> GetAllAsync();

    Category Get(Guid id);
    Task<Category> GetAsync(Guid id);

    Guid Add(Category category);
    Task<Guid> AddAsync(Category category);

    bool Delete(Guid id);
    Task<bool> DeleteAsync(Guid id);

    Guid Update(Category category);
    Task<Guid> UpdateAsync(Category category);
}