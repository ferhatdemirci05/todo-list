using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.DTO;

namespace ToDoList.Core.Business.Abstract
{
    public interface ITaskService
    {
        IEnumerable<TaskModel> GetAll();
        TaskModel GetById(int id);
        int Add(TaskModel model);
        bool Update(TaskModel model);
        bool Delete(int id);

        /// <summary>
        /// Görevi tamamlandı olarak günceller
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool ComplateTask(int id);
        /// <summary>
        /// Başlamayan Görevlerin Listesini döndürür
        /// </summary>
        /// <returns></returns>
        IEnumerable<TaskModel> MissingTasks();

        /// <summary>
        /// Tamamlanması gereken zamanda tamamlanmayan görevlerin listesini döndürür
        /// </summary>
        /// <returns></returns>
        IEnumerable<TaskModel> OutdatedTasks();

        /// <summary>
        /// Tamamlandı olarak işaretlenen görevleri döndürür
        /// </summary>
        /// <returns></returns>
        IEnumerable<TaskModel> CompletedTasks();
    }
}
