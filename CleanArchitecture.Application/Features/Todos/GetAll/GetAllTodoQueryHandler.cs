

using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Todos.GetAll;

internal sealed class GetAllTodoQueryHandler(
    ITodoRepository todoRepository) : IRequestHandler<GetAllTodoQuery, List<Todo>>
{
    public async Task<List<Todo>>Handle(GetAllTodoQuery request, CancellationToken cancellationToken)
    {
        List<Todo> todos = await todoRepository.GetAllAsync(cancellationToken);

        return todos;
    }
}