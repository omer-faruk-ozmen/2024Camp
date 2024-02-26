using CodingIO.Entities;

namespace CodingIO.Business.Abstracts;

public interface IInstructorService
{
    List<Instructor> GetAll();
    Task<List<Instructor>> GetAllAsync();

    Instructor Get(Guid id);
    Task<Instructor> GetAsync(Guid id);

    Guid Add(Instructor instructor);
    Task<Guid> AddAsync(Instructor instructor);

    bool Delete(Guid id);
    Task<bool> DeleteAsync(Guid id);

    Guid Update(Instructor instructor);
    Task<Guid> UpdateAsync(Instructor instructor);
}