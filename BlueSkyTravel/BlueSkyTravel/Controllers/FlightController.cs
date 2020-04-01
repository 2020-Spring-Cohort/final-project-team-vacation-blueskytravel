using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;
using BlueSkyTravel.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ViewResult Index()
        {
            var model = flightRepo.GetAll();
            return View(model);
        }

        // GET: Flight/Details/5
        public ViewResult Details(int id)
        {
            var model = flightRepo.GetById(id);
            return View(model);
        }

        // GET: Flight/Create
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        // POST: Flight/Create
        [HttpPost]
        public IActionResult Create(Flight flight)
        {
            flightRepo.Create(flight);
            return RedirectToAction("Index");
        }

        // GET: Flight/Edit/5
        [HttpGet]
        public ViewResult Update(int id)
        {
            Flight model = flightRepo.GetById(id);
            return View(model);
        }

        // POST: Flight/Edit/5
        [HttpPost]
        public IActionResult Update(Flight flight)
        {
            flightRepo.Update(flight);
            return RedirectToAction("Details", "Flight", new { id = flight.Id });
        }

        // GET: Flight/Delete/5
        [HttpGet]
        public ViewResult Delete(int id)
        {
            Flight model = flightRepo.GetById(id);
            return View(model);
        }

        // POST: Flight/Delete/5
        [HttpPost]
        public IActionResult Delete(Flight flight)
        {
            flightRepo.Delete(flight);
            return RedirectToAction("Index", "Flight");
        }
    }
}