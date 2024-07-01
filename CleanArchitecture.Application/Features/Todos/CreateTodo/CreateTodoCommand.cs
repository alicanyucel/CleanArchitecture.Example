using MediatR;

namespace CleanArchitecture.Application.Features.Todos.CreateTodo;

public sealed record CreateTodoCommand(string Work,DateOnly DeadLine,string? Note):IRequest;
