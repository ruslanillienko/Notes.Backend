using Microsoft.EntityFrameworkCore;
using ToDo.Application.Interfaces;
using ToDo.Domain;
using ToDo.Persistence.EntityTypeConfigurations;

namespace ToDo.Persistence
{
    public class ToDoDbContext : DbContext, IToDoDbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ToDoItemConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
