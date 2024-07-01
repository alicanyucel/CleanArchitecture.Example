using CleanArchitecture.Application.Features.Todos.CreateTodo;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastructure.Context;
using CleanArchitecture.Infrastructure.Repositories;

namespace CleanArchitecture.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(typeof(CreateTodoCommand).Assembly));
            builder.Services.AddScoped<ITodoRepository,TodoRepository>();
            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(action =>
            {

            });
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
