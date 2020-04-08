using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;
using BlueSkyTravel.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace BlueSkyTravel.Controllers
{
    public class ForFunController : Controller
    {
        IRepository<ForFun> funRepo;

        public ForFunController(IRepository<ForFun> funRepo)
        {
            this.funRepo = funRepo;
        }
        // GET: forFun
        [Authorize]
        public ViewResult Index()
        {
            var model = funRepo.GetAll();
            return View(model);
        }

        // GET: forFun/Details/5
        [Authorize]
        public ViewResult Details(int id)
        {
            var model = funRepo.GetById(id);
            return View(model);
        }

        // GET: forFun/Create
        [HttpGet]
        [Authorize]
        public ViewResult Create()
        {
            return View();
        }

        // POST: forFun/Create
        [HttpPost]
        [Authorize]
        public IActionResult Create(ForFun forFun)
        {
            funRepo.Create(forFun);
            return RedirectToAction("Index");
        }

        // GET: forFun/Edit/5
        [HttpGet]
        [Authorize]
        public ViewResult Update(int id)
        {
            ForFun model = funRepo.GetById(id);
            return View(model);
        }

        // POST: forFun/Edit/5
        [HttpPost]
        [Authorize]
        public IActionResult Update(ForFun forFun)
        {
            funRepo.Update(forFun);
            return RedirectToAction("Details", "ForFun", new { id = forFun.Id });
        }

        // GET: forFun/Delete/5
        [HttpGet]
        [Authorize]
        public ViewResult Delete(int id)
        {
            ForFun model = funRepo.GetById(id);
            return View(model);
        }

        // POST: forFun/Delete/5
        [HttpPost]
        [Authorize]
        public IActionResult Delete(ForFun forFun)
        {
            funRepo.Delete(forFun);
            return RedirectToAction("Details", "Itinerary", new { id = forFun.ItineraryId });
        }
    }
}