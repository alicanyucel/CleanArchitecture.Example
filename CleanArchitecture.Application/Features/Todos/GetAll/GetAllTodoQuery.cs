

using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.Todos.GetAll;
public sealed record GetAllTodoQuery() : IRequest<List<GetAllTodoQueryResponse>>;
