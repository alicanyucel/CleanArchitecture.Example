

using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories;

public sealed class TodoRepository(ApplicationDbContext context) : ITodoRepository
{
    public async Task AddAsync(Todo item, CancellationToken cancellationToken = default)
    {
        await context.AddAsync(item, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

    }

    public async Task DeleteAsync(Todo item, CancellationToken cancellationToken = default)
    {
        context.Remove(item);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<Todo>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Todos.ToListAsync(cancellationToken);
    }

    public async Task<Todo?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await context.Todos.FindAsync(id, cancellationToken);
    }

    public async Task UpdateAsync(Todo item, CancellationToken cancellationToken = default)
    {
        context.Update(item);
        await context.SaveChangesAsync(cancellationToken);
    }
}
