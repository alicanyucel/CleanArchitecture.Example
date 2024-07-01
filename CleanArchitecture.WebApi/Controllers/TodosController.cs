using CleanArchitecture.Application.Features.Todos.CreateTodo;
using CleanArchitecture.Application.Features.Todos.DeleteTodo;
using CleanArchitecture.Application.Features.Todos.GetAll;
using CleanArchitecture.Application.Features.Todos.UpdateTodo;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodosController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateTodoCommand request,CancellationToken cancellation)
        {
            await mediator.Send(request, cancellation);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateTodoCommand request,CancellationToken cancellation)
        {
            await mediator.Send(request,cancellation);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById(Guid id,CancellationToken cancellationtoken)
        {
            DeleteTodoByIdComamnd request = new(id);
            await mediator.Send(request, cancellationtoken);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellation)
        {
            GetAllTodoQuery request = new();
            List<Todo> todos = await mediator.Send(request, cancellation);
            return Ok(todos);
        }
    }
}
