using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcTraining.Services;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Controllers
{
    public class SchedulerController : Controller
    {
        public SchedulerTaskService TaskService { get; set; }

        public SchedulerController(SchedulerTaskService taskService)
        {
            TaskService = taskService;
        }

        public ActionResult BasicScheduler()
        {
            return View();
        }

        public ActionResult ProScheduler()
        {
            return View();
        }

        public virtual JsonResult Basic_Usage_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(TaskService.GetAll().ToDataSourceResult(request));
        }

        public virtual JsonResult Basic_Usage_Destroy([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        {
            if (ModelState.IsValid)
            {
                TaskService.Delete(task, ModelState);
            }

            return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        }

        public virtual JsonResult Basic_Usage_Create([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        {
            if (ModelState.IsValid)
            {
                TaskService.Insert(task, ModelState);
            }

            return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        }

        public virtual JsonResult Basic_Usage_Update([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        {
            if (ModelState.IsValid)
            {
                TaskService.Update(task, ModelState);
            }

            return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        }
    }
}
