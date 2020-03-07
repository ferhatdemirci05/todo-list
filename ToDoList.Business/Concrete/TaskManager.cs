using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Business.Abstract;
using ToDoList.Data.Abstract;
using ToDoList.Domain.DTO;

namespace ToDoList.Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskDal _taskDal;
        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public int Add(TaskModel model)
        {
            var record = new Entities.Concrete.Task();
            record.Detail = model.Detail;
            record.StartingDate = model.StartingDate;
            record.ExpirationDate = model.ExpirationDate;
            record.CreationDate = DateTime.Now;

            record = _taskDal.Add(record);
            return record.Id;
        }



        public bool Delete(int id)
        {
            var result = false;

            var record = GetTaskById(id);
            if (record != null)
            {
                record.IsDeleted = true;
                _taskDal.Update(record);
                result = !result;
            }
            return result;
        }


        public IEnumerable<TaskModel> GetAll()
        {
            return _taskDal.GetList(x=>!x.IsDeleted).Select(x => new TaskModel
            {
                TaskId = x.Id,
                Detail = x.Detail,
                ExpirationDate = x.ExpirationDate,
                StartingDate = x.StartingDate,
                ComplationDate= x.ComplationDate,
                CreationDate = x.CreationDate
            });
        }

     

        public TaskModel GetById(int id)
        {
            var result = new TaskModel();
            var record = GetTaskById(id);

            if (record != null)
            {
                result.Detail = record.Detail;
                result.StartingDate = record.StartingDate;
                result.ExpirationDate = record.ExpirationDate;
            }
            return result;
        }


        public bool Update(TaskModel model)
        {
            var result = false;
            var record = GetTaskById(model.TaskId);

            if (record != null)
            {
                record.Detail = model.Detail;
                record.StartingDate = model.StartingDate;
                record.ExpirationDate = model.ExpirationDate;

                _taskDal.Update(record);
                result = !result;
            }
            return result;
        }
        public bool ComplateTask(int id)
        {
            var result = false;

            var record = GetTaskById(id);

            if (record != null)
            {
                record.HasDone = true;
                record.ComplationDate = DateTime.Now;
                _taskDal.Update(record);
                result = !result;
            }

            return result;
        }
        private Entities.Concrete.Task GetTaskById(int id)
        {
            return _taskDal.Get(x => x.Id == id);
        }

        public IEnumerable<TaskModel> MissingTasks()
        {
            return _taskDal.GetList(x => x.StartingDate > DateTime.Now && !x.HasDone && !x.IsDeleted).Select(x => new TaskModel
            {
                TaskId = x.Id,
                Detail = x.Detail,
                StartingDate = x.StartingDate,
                ExpirationDate = x.ExpirationDate,
                ComplationDate = x.ComplationDate,
                CreationDate = x.CreationDate
            });
        }

        public IEnumerable<TaskModel> OutdatedTasks()
        {
            return _taskDal.GetList(x => x.ExpirationDate < DateTime.Now && !x.HasDone && !x.IsDeleted).Select(x => new TaskModel
            {
                TaskId = x.Id,
                Detail = x.Detail,
                StartingDate = x.StartingDate,
                ComplationDate= x.ComplationDate,
                ExpirationDate = x.ExpirationDate,
                CreationDate = x.CreationDate
            });
        }
        public IEnumerable<TaskModel> CompletedTasks()
        {
            return _taskDal.GetList(x => x.HasDone && !x.IsDeleted).Select(x => new TaskModel
            {
                TaskId = x.Id,
                Detail = x.Detail,
                StartingDate = x.StartingDate,
                ComplationDate= x.ComplationDate,
                ExpirationDate = x.ExpirationDate,
                CreationDate = x.CreationDate
            });
        }
    }
}
