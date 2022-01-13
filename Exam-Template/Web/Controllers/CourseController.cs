using GP.Domain.Entities;
using GP.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Web.Controllers
{
    public class CourseController : Controller
    {
         readonly ICourseService courseService;
         readonly IVoitureService voitureService;
         readonly IClientService clientService;


        public CourseController(ICourseService courseService, IClientService clientService, IVoitureService voitureService)
        {
           this.courseService = courseService;
           this.clientService = clientService;
            this.voitureService = voitureService;
        }
        // GET: CourseController
        public ActionResult Index()
        {
            return View(courseService.GetMany());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            //(list, id, retour)
            ViewBag.VoitureId = new SelectList(voitureService.GetMany(), "NumMat", "NumMat");
            ViewBag.ClientId = new SelectList(clientService.GetMany(), "CIN", "CIN");
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            
            try
            {
                courseService.Add(course);
                courseService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int? id)
        {
            
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Course course)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
