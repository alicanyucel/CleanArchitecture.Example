using MediatR;

namespace CleanArchitecture.Application.Features.Todos.UpdateTodo;

public sealed record UpdateTodoCommand(Guid Id, string Work, DateOnly DeadLine, string? Note, bool IsCompleted) : IRequest;
