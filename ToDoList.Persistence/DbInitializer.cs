namespace ToDo.Persistence
{
    internal class DbInitializer
    {
        public static void Initialize(ToDoDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
