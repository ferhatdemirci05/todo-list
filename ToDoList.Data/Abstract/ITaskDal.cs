using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.DataAccess;

namespace ToDoList.Data.Abstract
{
    public interface ITaskDal: IEntityRepository<Entities.Concrete.Task>
    {

    }
}
