using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoLists.Domain;

namespace ToDoLists.Persistence.EntityTypeConfigurations
{
    public class ToDoListConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasKey(toDoList => toDoList.Id);
            builder.HasIndex(toDoList => toDoList.Id).IsUnique();
            builder.Property(toDoList => toDoList.Title).HasMaxLength(250);
        }
    }
}
