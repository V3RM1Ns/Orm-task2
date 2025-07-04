using Orm_Task2.Core.Entities;

namespace Orm_Task2.DAL.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    public void Add(TEntity entity);
    public void Delete(TEntity entity);
    public void Update(TEntity entity);
    public TEntity GetById(int id);
}