
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Repositories;

public interface ITodoRepository
{
    Task AddAsync(Todo item, CancellationToken cancellationToken = default);
    Task UpdateAsync(Todo item, CancellationToken cancellationToken = default);
    Task DeleteAsync(Todo item, CancellationToken cancellationToken = default);
    Task<List<Todo>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Todo?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}