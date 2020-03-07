using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.DataAccess.EntityFramework;
using ToDoList.Data.Abstract;

namespace ToDoList.Data.Concrete.EntityFramework
{
    public class EfTaskDal: EfEntityRepositoryBase<Entities.Concrete.Task, ToDoListContext>, ITaskDal
    {

    }
}
