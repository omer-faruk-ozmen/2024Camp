using CodingIO.Entities;

namespace CodingIO.Business.Abstracts;

public interface ICourseService
{
    List<Course> GetAll();
    Task<List<Course>> GetAllAsync();

    Course Get(Guid id);
    Task<Course> GetAsync(Guid id);

    Guid Add(Course course);
    Task<Guid> AddAsync(Course course);

    bool Delete(Guid id);
    Task<bool> DeleteAsync(Guid id);

    Guid Update(Course course);
    Task<Guid> UpdateAsync(Course course);
}