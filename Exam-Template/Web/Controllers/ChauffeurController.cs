using GP.Domain.Entities;
using GP.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Web.Controllers
{
    public class ChauffeurController : Controller
    {
        readonly IChauffeurService chauffeurService;
        readonly IVoitureService voitureService;

        public ChauffeurController(IChauffeurService chauffeurService, IVoitureService voitureService)
        {
            this.chauffeurService = chauffeurService;
            this.voitureService = voitureService;
        }

        // GET: ChauffeurController
        public ActionResult Index()
        {
            return View(chauffeurService.GetMany());
        }

        // GET: ChauffeurController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChauffeurController/Create
        public ActionResult Create()
        {
            ViewBag.voitureFK = new SelectList(voitureService.GetMany(), "NumMat", "NumMat");
            return View();
        }

        // POST: ChauffeurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chauffeur chauffeur)
        {
            try
            {
                chauffeurService.Add(chauffeur);
                chauffeurService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChauffeurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChauffeurController/Edit/5
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

        // GET: ChauffeurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChauffeurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
