using CodingIO.DataAccess.Abstracts;
using CodingIO.Entities;

namespace CodingIO.DataAccess.Concretes;

public class Repository<T> : IRepository<T> where T:BaseEntity
{
    private List<T> entities;
    public Repository()
    {
        entities = new List<T>();
    }
    
    public List<T> GetAll()
    {
        return entities.ToList();
    }

    public async Task<List<T>> GetAllAsync()
    {
        //Async
        return await Task.FromResult(entities.ToList());
    }

    public T Get(Guid id)
    {
        return entities.Single(p=>p.Id ==id);;
    }

    public async Task<T> GetAsync(Guid id)
    {
        //Async
        var entity = entities.Single(p => p.Id == id);

        return await Task.FromResult(entity);
    }

    public Guid Add(T entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.Now;
        entity.UpdatedDate = null;
        entity.DeletedDate = null;
        
        entities.Add(entity);

        return entity.Id;
    }

    public async Task<Guid> AddAsync(T entity)
    {
        
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.Now;
        entity.UpdatedDate = null;
        entity.DeletedDate = null;
        
        //AddAsync
        entities.Add(entity);

        return await Task.FromResult(entity.Id);
    }

    public bool Delete(Guid id)
    {
        var entity = entities.Single(p => p.Id == id);
        entity.DeletedDate = DateTime.Now;

        return true;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var entity = entities.Single(p => p.Id == id);
        entity.DeletedDate = DateTime.Now;

        return await Task.FromResult(true);
    }

    public Guid Update(T entity)
    {
        var tEntity = entities.Single(p => p.Id == entity.Id);

        tEntity = entity;
        tEntity.UpdatedDate = DateTime.Now;

        return tEntity.Id;
    }

    public Task<Guid> UpdateAsync(T entity)
    {
        var tEntity = entities.Single(p => p.Id == entity.Id);

        tEntity = entity;
        tEntity.UpdatedDate = DateTime.Now;

        return Task.FromResult(tEntity.Id);
    }
}