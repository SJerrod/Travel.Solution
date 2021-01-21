using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;
using TravelClient.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TravelClient.Controllers
{
    public class DestinationsController : Controller
    {

        public IActionResult Index()
        {
            var allDestinations = Destination.GetDestinations();
            return View(allDestinations);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Destination destination)
        {
            _db.Destinations.Add(destination);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var thisDestination = _db.Destinations.FirstOrDefault(destination => destination.DestinationId == id);
            return View(thisDestination);
        }

        [HttpPost]
        public ActionResult Edit(Destination destination)
        {
            _db.Entry(destination).State = EntityState.Modified; 
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisDestination = _db.Destinations.FirstOrDefault(destination => destination.DestinationId == id);
            return View(thisDestination);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisDestination = _db.Destinations.FirstOrDefault(destination => destination.DestinationId == id);
            _db.Destinations.Remove(thisDestination);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}