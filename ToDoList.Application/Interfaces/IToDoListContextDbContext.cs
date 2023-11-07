using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using ToDoLists.Domain;

namespace ToDoLists.Application.Interfaces
{
    public interface IToDoListContextDbContext
    {
        DbSet<ToDoList> ToDoLists { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
