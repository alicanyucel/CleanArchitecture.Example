

using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Todos.DeleteTodo;

internal sealed class DeleteTodoByIdCommandHandler(ITodoRepository todoRepository) : IRequestHandler<DeleteTodoByIdComamnd>
{
    public async Task Handle(DeleteTodoByIdComamnd request, CancellationToken cancellationToken)
    {
        Todo? todo = await todoRepository.GetByIdAsync(request.id, cancellationToken);
        if(todo is null)
        {
            throw new ArgumentNullException("todo yok");
        }
        await todoRepository.DeleteAsync(todo, cancellationToken);
    }
}
