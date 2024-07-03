

using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Todos.GetAll;

internal sealed class GetAllTodoQueryHandler(
    ITodoRepository todoRepository) : IRequestHandler<GetAllTodoQuery, List<GetAllTodoQueryResponse>>
{
    public async Task<List<GetAllTodoQueryResponse>>Handle(GetAllTodoQuery request, CancellationToken cancellationToken)
    {
        List<Todo> todos = await todoRepository.GetAllAsync(cancellationToken);
        List<GetAllTodoQueryResponse> response = todos.Select(s => new GetAllTodoQueryResponse(s.Id, s.Work, s.DeadLine, s.IsCompleted, s.Note)).ToList();
        return response;

    }
}