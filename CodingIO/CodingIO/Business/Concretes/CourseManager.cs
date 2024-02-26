using CodingIO.Business.Abstracts;
using CodingIO.DataAccess.Abstracts;
using CodingIO.Entities;

namespace CodingIO.Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;
    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public async Task<List<Course>> GetAllAsync()
    {
        var courses = await _courseDal.GetAllAsync();
        
        return await Task.FromResult(courses);
    }

    public Course Get(Guid id)
    {
        return _courseDal.Get(id);
    }

    public async Task<Course> GetAsync(Guid id)
    {
        var course = await _courseDal.GetAsync(id);
        return await Task.FromResult(course);
    }

    public Guid Add(Course course)
    {
        var courseId = _courseDal.Add(course);
        return courseId;
    }

    public async Task<Guid> AddAsync(Course course)
    {
        var courseId = await _courseDal.AddAsync(course);

        return await Task.FromResult(courseId);
    }

    public bool Delete(Guid id)
    {
        var isDeleted = _courseDal.Delete(id);
        return isDeleted;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var isDeleted = await _courseDal.DeleteAsync(id);
        return await Task.FromResult(isDeleted);
    }

    public Guid Update(Course course)
    {
        var result = _courseDal.Update(course);
        return result;
    }

    public async Task<Guid> UpdateAsync(Course course)
    {
        var result = await _courseDal.UpdateAsync(course);
        return await Task.FromResult(result);
    }
}