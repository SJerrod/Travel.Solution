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

    public IActionResult Details(int id)
    {
      var thisDestination = Destination.GetDetails(id);
      return View(thisDestination);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Destination destination)
    {
      Destination.Post(destination);
      return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
      var thisDestination = Destination.GetDetails(id);
      return View(thisDestination);
    }

    [HttpPost]
    public IActionResult Edit(Destination destination)
    {
      Destination.Put(destination);
      return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
      Destination.Delete(id);
      return RedirectToAction("Index");
    }

    // [HttpPost, ActionName("Delete")]
    // public IActionResult DeleteConfirmed(int id)
    // {
    //     var thisDestination = Destination.FirstOrDefault(destination => destination.DestinationId == id);
    //     Destination.Remove(thisDestination);
    //     SaveChanges();
    //     return RedirectToAction("Index");
    // }
  }
}