using Microsoft.EntityFrameworkCore;
using Orm_Task2.Core.Entities;
using Orm_Task2.DAL.Contexts;
using Orm_Task2.DAL.Repositories.Interfaces;

namespace Orm_Task2.DAL.Repositories.Concretes;

public class Repository<TEntity>:IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly OrmDbContex _ormDbContex;
    public DbSet<TEntity> Table { get; set; }
    public Repository()
    {
        _ormDbContex = new OrmDbContex();
        Table=_ormDbContex.Set<TEntity>();
    }
    public void Add(TEntity entity)
    {
        Table.Add(entity);
        _ormDbContex.SaveChanges();
    }

    public void Delete(TEntity entity)
    { 
        Table.Remove(entity);
        _ormDbContex.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        Table.Update(entity);
        _ormDbContex.SaveChanges();
    }

    public TEntity GetById(int id)
    { 
        return Table.FirstOrDefault(x => x.Id == id);
    }
}