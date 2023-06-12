﻿
using Compras.Domain.Common;

namespace Compras.Application.Contracts.Persistence;

public interface IGenericRepository <T> where T: BaseEntity
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity); 
}
