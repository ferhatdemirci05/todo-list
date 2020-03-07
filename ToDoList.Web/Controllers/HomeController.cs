using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ToDoList.Core.Business.Abstract;
using ToDoList.Domain.DTO;

namespace ToDoList.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;
        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public ActionResult Index()
        {
            var taskList = _taskService.GetAll();
            return View(taskList);
        }

        [HttpPost]
        public ActionResult Index(TaskModel model)
        {
            var result = _taskService.Add(model);
            if (result != 0)
                TempData["recordStatus"] = true;
            else
                TempData["recordStatus"] = false;

            return RedirectToAction("index");
        }

        [HttpPost]
        public JsonResult removeTask(int taskId)
        {
            var result = _taskService.Delete(taskId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ComplateTask(int taskId)
        {
            var result = _taskService.ComplateTask(taskId);
            TempData["complateTask"] = true;
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getTask(int taskId)
        {
            var result = _taskService.GetById(taskId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateTask(TaskModel model)
        {
            var result = _taskService.Update(model);
            TempData["updateTask"] = true;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}