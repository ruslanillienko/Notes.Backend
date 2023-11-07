using Microsoft.EntityFrameworkCore;
using ToDoLists.Application.Interfaces;
using ToDoLists.Domain;
using ToDoLists.Persistence.EntityTypeConfigurations;

namespace ToDoLists.Persistence
{
    public class ToDoListsDbContext : DbContext, IToDoListContextDbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        public ToDoListsDbContext(DbContextOptions<ToDoListsDbContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ToDoListConfiguration());
            base.OnModelCreating(builder);
        }

    }
}
