﻿namespace Common.Core.Infrastructure.Persistence.Repository.Interface;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetByIdAsync(Guid id);
    Task<bool> IsExistsAsync(Guid id);
    Task<List<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity, CancellationToken cancellationToken);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);
}
