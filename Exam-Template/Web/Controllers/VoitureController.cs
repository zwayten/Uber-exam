using GP.Domain.Entities;
using GP.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Web.Controllers
{
    public class VoitureController : Controller
    {
        readonly IVoitureService voitureService;

        public VoitureController(IVoitureService voitureService)
        {
            this.voitureService = voitureService;
        }


        // GET: VoitureController
        public ActionResult Index(string filtre)
        {
            var voiture = voitureService.GetMany();
            if (filtre == "" || filtre == null)
            {
                voiture = voitureService.GetMany();
            }
            else
            {
                voiture = voitureService.GetMany(p => p.NumMat.Contains(filtre));
                if(voiture == null)
                {
                    return NotFound();
                }
            }
            return View(voiture);
        }

        // GET: VoitureController/Details/5
        public ActionResult Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var voiture = voitureService.GetMany().FirstOrDefault(m => m.NumMat == id);
            if (voiture == null)
            {
                return NotFound();
            }
            return View(voiture);
        }

        // GET: VoitureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VoitureController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Voiture voiture)
        {
            try
            {
                voitureService.Add(voiture);
                voitureService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VoitureController/Edit/5
        public ActionResult Edit(string id)
        {
            
            var voiture = voitureService.GetById(id);
            if (voiture == null)
            {
                return NotFound();
            }
            return View(voiture);
        }

        // POST: VoitureController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            


                try
                {
                    var voiture = voitureService.GetById(id);
                    voitureService.Update(voiture);
                    voitureService.Commit();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            
        }

        // GET: VoitureController/Delete/5
        public ActionResult Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var voiture = voitureService.GetMany().FirstOrDefault(m => m.NumMat == id);
            if(voiture == null)
            {
                return NotFound();
            }
            return View(voiture);
        }

        // POST: VoitureController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                var voiture = voitureService.GetById(id);
                voitureService.Delete(voiture);
                voitureService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
