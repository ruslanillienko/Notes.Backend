using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLists.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(ToDoListsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
