using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.DTO
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string Detail { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ComplationDate { get; set; }
    }
}
