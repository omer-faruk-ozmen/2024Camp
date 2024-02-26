using CodingIO.Business.Abstracts;
using CodingIO.DataAccess.Abstracts;
using CodingIO.Entities;

namespace CodingIO.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public async Task<List<Category>> GetAllAsync()
    {
        var categories = await _categoryDal.GetAllAsync();
        
        return await Task.FromResult(categories);
    }

    public Category Get(Guid id)
    {
        return _categoryDal.Get(id);
    }

    public async Task<Category> GetAsync(Guid id)
    {
        var category = await _categoryDal.GetAsync(id);
        return await Task.FromResult(category);
    }

    public Guid Add(Category category)
    {
        var categoryId = _categoryDal.Add(category);
        return categoryId;
    }

    public async Task<Guid> AddAsync(Category category)
    {
        var categoryId = await _categoryDal.AddAsync(category);

        return await Task.FromResult(categoryId);
    }

    public bool Delete(Guid id)
    {
        var isDeleted = _categoryDal.Delete(id);
        return isDeleted;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var isDeleted = await _categoryDal.DeleteAsync(id);
        return await Task.FromResult(isDeleted);
    }

    public Guid Update(Category category)
    {
        var result = _categoryDal.Update(category);
        return result;
    }

    public async Task<Guid> UpdateAsync(Category category)
    {
        var result = await _categoryDal.UpdateAsync(category);
        return await Task.FromResult(result);
    }
}