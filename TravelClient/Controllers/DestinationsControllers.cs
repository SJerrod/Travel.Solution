using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;
using TravelClient.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace TravelClient.Controllers
{
    public class DestinationsController : Controller
    {

        public IActionResult Index()
        {
            var allDestinations = Destination.GetDestinations();
            return View(allDestinations);
        }

    }
}