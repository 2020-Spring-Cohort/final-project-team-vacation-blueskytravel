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
    public class VoteController : Controller
    {
        IRepository<Vote> voteRepo;

        public VoteController(IRepository<Vote> voteRepo)
        {
            this.voteRepo = voteRepo;
        }
        // GET: Vote
        public ViewResult Index()
        {
            var model = voteRepo.GetAll();
            return View(model);
        }

        // GET: Vote/Details/5
        public ViewResult Details(int id)
        {
            var model = voteRepo.GetById(id);
            return View(model);
        }

        // GET: Vote/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vote/Create
        [HttpPost]
        public IActionResult Create(Vote vote)
        {
            voteRepo.Create(vote);
            return RedirectToAction("Index");
        }

        // GET: Vote/Edit/5
        [HttpGet]
        public ViewResult Update(int id)
        {
            Vote model = voteRepo.GetById(id);
            return View(model);
        }

        // POST: Vote/Edit/5
        [HttpPost]

        public IActionResult Update(Vote vote)
        {
            voteRepo.Update(vote);
            return RedirectToAction("Details", "Vote", new { id = vote.Id });
        }

        // GET: Vote/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Vote model = voteRepo.GetById(id);
            return View(model);
        }

        // POST: Vote/Delete/5
        [HttpPost]
        public IActionResult Delete(Vote vote)
        {
            voteRepo.Delete(vote);
            return RedirectToAction("Index", "Vote");
        }
    }
}