using System;
using MediatR;

namespace ToDo.Application.ToDo.Commands.CreateTodoItem
{
    internal class CreateToDoItemCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
    }
}
