using CodingIO.Business.Abstracts;
using CodingIO.DataAccess.Abstracts;
using CodingIO.Entities;

namespace CodingIO.Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public async Task<List<Instructor>> GetAllAsync()
    {
        var instructors = await _instructorDal.GetAllAsync();
        
        return await Task.FromResult(instructors);
    }

    public Instructor Get(Guid id)
    {
        return _instructorDal.Get(id);
    }

    public async Task<Instructor> GetAsync(Guid id)
    {
        var instructor = await _instructorDal.GetAsync(id);
        return await Task.FromResult(instructor);
    }

    public Guid Add(Instructor instructor)
    {
        var instructorId = _instructorDal.Add(instructor);
        return instructorId;
    }

    public async Task<Guid> AddAsync(Instructor instructor)
    {
        var instructorId = await _instructorDal.AddAsync(instructor);

        return await Task.FromResult(instructorId);
    }

    public bool Delete(Guid id)
    {
        var isDeleted = _instructorDal.Delete(id);
        return isDeleted;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var isDeleted = await _instructorDal.DeleteAsync(id);
        return await Task.FromResult(isDeleted);
    }

    public Guid Update(Instructor instructor)
    {
        var result = _instructorDal.Update(instructor);
        return result;
    }

    public async Task<Guid> UpdateAsync(Instructor instructor)
    {
        var result = await _instructorDal.UpdateAsync(instructor);
        return await Task.FromResult(result);
    }
}