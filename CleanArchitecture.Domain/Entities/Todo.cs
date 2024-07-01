using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public sealed class Todo
{
    public Guid Id { get; set; } //0000-000-000
    public string Work { get; set; } = default!;
    public DateOnly DeadLine { get; set; } //01-01-0001
    public bool IsCompleted { get; set; } //false
    public string? Note { get; set; }
}
