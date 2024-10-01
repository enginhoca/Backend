using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TechZone.Entities.Abstract;

namespace TechZone.DataAccess.Concrete;

public class EfBaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext
{
    private readonly TContext _context;

    // DI aracılığıyla context'i alın
    public EfBaseRepository(TContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var deleteEntity = await _context.Set<TEntity>().FindAsync(id);
        _context.Set<TEntity>().Remove(deleteEntity);
        var data = await _context.SaveChangesAsync();
        return data > 0;
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await _context.Set<TEntity>().SingleOrDefaultAsync(filter);
    }

    public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
    {
        return filter == null
            ? await _context.Set<TEntity>().ToListAsync()
            : await _context.Set<TEntity>().Where(filter).ToListAsync();
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}








