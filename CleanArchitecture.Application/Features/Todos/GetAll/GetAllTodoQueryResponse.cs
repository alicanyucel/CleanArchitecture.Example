namespace CleanArchitecture.Application.Features.Todos.GetAll;

public sealed record GetAllTodoQueryResponse(Guid id,string Work,DateOnly Deadline,bool IsCompleted,string? Note);