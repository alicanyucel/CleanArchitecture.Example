using MediatR;

namespace CleanArchitecture.Application.Features.Todos.DeleteTodo;

public sealed record DeleteTodoByIdComamnd(Guid id): IRequest;
