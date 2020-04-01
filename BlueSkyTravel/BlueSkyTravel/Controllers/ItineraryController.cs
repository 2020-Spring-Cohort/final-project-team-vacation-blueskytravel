using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlueSkyTravel.Repositories;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Controllers
{
    public class ItineraryController : Controller
    {
        IRepository<Itinerary> itineraryRepo;

        public ItineraryController(IRepository<Itinerary> itineraryRepo)
        {
            this.itineraryRepo = itineraryRepo;
        }

        // GET: Itinerary
        public ViewResult Index()
        {
            var model = itineraryRepo.GetAll();
            return View(model);
        }

        // GET: Itinerary/Details/5
        public ViewResult Details(int id)
        {
            var model = itineraryRepo.GetById(id);
            return View(model);
        }

        // GET: Itinerary/Create
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        // POST: Itinerary/Create
        [HttpPost]
        public IActionResult Create(Itinerary itinerary)
        {
            itineraryRepo.Create(itinerary);
            return RedirectToAction("Index");
        }

        // GET: Itinerary/Edit/5
        [HttpGet]
        public ViewResult Update(int id)
        {
            Itinerary model = itineraryRepo.GetById(id);
            return View(model);
        }

        // POST: Itinerary/Edit/5
        [HttpPost]
        public IActionResult Update(Itinerary itinerary)
        {
            itineraryRepo.Update(itinerary);
            return RedirectToAction("Details", "Itinerary", new { id = itinerary.Id });
        }

        // GET: Itinerary/Delete/5
        [HttpGet]
        public ViewResult Delete(int id)
        {
            Itinerary model = itineraryRepo.GetById(id);
            return View(model);
        }

        // POST: Itinerary/Delete/5
        [HttpPost]
        public IActionResult Delete(Itinerary itinerary)
        {
            itineraryRepo.Delete(itinerary);
            return RedirectToAction("Index", "Itinerary");
        }
    }
}