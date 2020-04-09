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
    public class FlightController : Controller
    {
        IRepository<Flight> flightRepo;

        public FlightController(IRepository<Flight> flightRepo)
        {
            this.flightRepo = flightRepo;
        }
        // GET: Flight
        [Authorize]
        public ViewResult Index()
        {
            var model = flightRepo.GetAll();
            return View(model);
        }

        // GET: Flight/Details/5
        [Authorize]
        public ViewResult Details(int id)
        {
            var model = flightRepo.GetById(id);
            return View(model);
        }

        // GET: Flight/Create
        [HttpGet]
        [Authorize]
        public ViewResult CreateByItineraryId(int id)
        {
            ViewBag.ItineraryId = id;
            return View();
        }

        // POST: Flight/Create
        [HttpPost]
        [Authorize]
        public IActionResult Create(Flight flight)
        {
            flightRepo.Create(flight);
            return RedirectToAction("Details", "Itinerary", new { id = flight.ItineraryId });
        }

        // GET: Flight/Edit/5
        [HttpGet]
        [Authorize]
        public ViewResult Update(int id)
        {
            Flight model = flightRepo.GetById(id);
            return View(model);
        }

        // POST: Flight/Edit/5
        [HttpPost]
        [Authorize]
        public IActionResult Update(Flight flight)
        {
            flightRepo.Update(flight);
            return RedirectToAction("Details", "Flight", new { id = flight.Id });
        }

        // GET: Flight/Delete/5
        [HttpGet]
        [Authorize]
        public ViewResult Delete(int id)
        {
            Flight model = flightRepo.GetById(id);
            return View(model);
        }

        // POST: Flight/Delete/5
        [HttpPost]
        [Authorize]
        public IActionResult Delete(Flight flight)
        {
            var tempId = flight.ItineraryId;
            flightRepo.Delete(flight);
            return RedirectToAction("Details", "Itinerary", new { id = tempId });
        }
    }
}