using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Core.Business.Abstract;

namespace ToDoList.Web.Controllers
{
    public class OutdatedController : Controller
    {
        private readonly ITaskService _taskService;
        public OutdatedController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public ActionResult Index()
        {
            var taskList = _taskService.OutdatedTasks();
            return View("~/Views/Home/Index.cshtml", taskList);
        }
    }
}