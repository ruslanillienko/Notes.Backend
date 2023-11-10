using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDo.Application.Interfaces;
using ToDo.Domain;

namespace ToDo.Application.ToDo.Commands.CreateTodoItem
{
    internal class CreateToDoItemCommandHandler
        : IRequestHandler<CreateToDoItemCommand, Guid>
    {
        private readonly IToDoDbContext _dbContext;

        public CreateToDoItemCommandHandler(IToDoDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(CreateToDoItemCommand request,
            CancellationToken cancellationToken)
        {
            var note = new ToDoItem
            {
                UserId = request.UserId,
                ItemName = request.ItemName,
                ItemDescription = request.ItemDescription,
                ItemStatus = false,
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
                EditDate = null
            };

            await _dbContext.ToDoItems.AddAsync(note, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return note.Id;
        }
    }
}
