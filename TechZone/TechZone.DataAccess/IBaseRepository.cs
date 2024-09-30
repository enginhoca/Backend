using System;
using System.Linq.Expressions;
using TechZone.Entities.Abstract;

namespace TechZone.DataAccess;

public interface IBaseRepository<T> where T:class, IEntity,new()
{
    Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> filter=null);
    Task<T> GetAsync(Expression<Func<T, bool>> filter);
    Task<T> AddAsync(T Entity);
    Task<T> UpdateAsync(T Entity);
    Task<bool> DeleteAsync(int id);
}
