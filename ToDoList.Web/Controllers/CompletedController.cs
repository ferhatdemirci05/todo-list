using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Core.Business.Abstract;

namespace ToDoList.Web.Controllers
{
    public class CompletedController : Controller
    {
        private readonly ITaskService _taskService;
        public CompletedController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public ActionResult Index()
        {
            var taskList = _taskService.CompletedTasks();
            return View("~/Views/Home/Index.cshtml", taskList);
        }
    }
}