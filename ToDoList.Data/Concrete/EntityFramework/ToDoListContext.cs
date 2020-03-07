using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Concrete.EntityFramework.Mapping;

namespace ToDoList.Data.Concrete.EntityFramework
{
   public class ToDoListContext: DbContext
    {
        public ToDoListContext()
        {
            Database.SetInitializer<ToDoListContext>(null);
        }

        public DbSet<Entities.Concrete.Task> Tasks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}
