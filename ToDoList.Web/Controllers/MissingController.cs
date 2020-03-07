using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Core.Business.Abstract;

namespace ToDoList.Web.Controllers
{
    public class MissingController : Controller
    {
        private readonly ITaskService _taskService;
        public MissingController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public ActionResult Index()
        {
            var taskList = _taskService.MissingTasks();
            return View("~/Views/Home/Index.cshtml", taskList);
        }
    }
}