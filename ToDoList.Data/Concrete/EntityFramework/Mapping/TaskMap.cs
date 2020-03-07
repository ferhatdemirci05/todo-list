using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Data.Concrete.EntityFramework.Mapping
{
   public class TaskMap : EntityTypeConfiguration<Entities.Concrete.Task>
    {
        public TaskMap()
        {
            ToTable("Tasks", "dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Detail).HasColumnName("Detail");
            Property(x => x.StartingDate).HasColumnName("StartingDate");
            Property(x => x.ExpirationDate).HasColumnName("ExpirationDate");
            Property(x => x.ComplationDate).HasColumnName("ComplationDate");
            Property(x => x.CreationDate).HasColumnName("CreationDate");
            Property(x => x.HasDone).HasColumnName("HasDone");
            Property(x => x.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
