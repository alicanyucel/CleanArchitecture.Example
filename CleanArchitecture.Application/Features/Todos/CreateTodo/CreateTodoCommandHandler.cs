using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Todos.CreateTodo;

internal sealed class CreateTodoCommandHandler(ITodoRepository todoRepository) : IRequestHandler<CreateTodoCommand>
{
    public async Task Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        Todo todo = new()
        {
            Id=Guid.NewGuid(),
            Work=request.Work,
            DeadLine=request.DeadLine,
            Note=request.Note,
            IsCompleted=false
        };
        await todoRepository.AddAsync(todo,cancellationToken);
    }
}