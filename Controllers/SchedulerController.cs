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

        public SchedulerMeetingService MeetingService { get; set; }

        public SchedulerController(SchedulerTaskService taskService, SchedulerMeetingService meetingService)
        {
            TaskService = taskService;
            MeetingService = meetingService;
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

        public virtual JsonResult Resources_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(MeetingService.GetAll().ToDataSourceResult(request));
        }

        public virtual JsonResult Resources_Destroy([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting)
        {
            if (ModelState.IsValid)
            {
                MeetingService.Delete(meeting, ModelState);
            }

            return Json(new[] { meeting }.ToDataSourceResult(request, ModelState));
        }

        public virtual JsonResult Resources_Create([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting)
        {
            if (ModelState.IsValid)
            {
                MeetingService.Insert(meeting, ModelState);
            }

            return Json(new[] { meeting }.ToDataSourceResult(request, ModelState));
        }

        public virtual JsonResult Resources_Update([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting)
        {
            if (ModelState.IsValid)
            {
                MeetingService.Update(meeting, ModelState);
            }

            return Json(new[] { meeting }.ToDataSourceResult(request, ModelState));
        }
    }
}
