using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Entities;

namespace ToDoList.Entities.Concrete
{
    public class Task:IEntity
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime? ComplationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool HasDone { get; set; }
        public bool IsDeleted { get; set; }
    }
}
