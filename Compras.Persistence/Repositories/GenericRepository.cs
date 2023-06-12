
using Compras.Application.Contracts.Persistence;
using Compras.Domain.Common;
using Compras.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Compras.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly ComprasDatabaseContext context;

    public GenericRepository(ComprasDatabaseContext context)
    {
        this.context = context;
    }

    

    protected ComprasDatabaseContext Context => context;

    public async Task CreateAsync(T entity)
    {
        await context.AddAsync(entity);
        await context.SaveChangesAsync(); 
    }

    public async Task DeleteAsync(T entity)
    {
        context.Remove(entity);
        await context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await context.Set<T>().
            AsNoTracking().ToListAsync(); 
    }



    public async Task<T> GetByIdAsync(int id)
    {
        var entity = await context.Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(q => q.Id == id);
        return entity!; 
    }

    public async Task UpdateAsync(T entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync(); 
    }
}
