using System.Collections.Generic;
using System.Linq;
using TravelAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/destinations")]
  [ApiController]
  public class DestinationsV1Controller : ControllerBase
  {
    private TravelAPIContext _db;

    public DestinationsV1Controller(TravelAPIContext db)
    {
      _db = db;
    }

    // GET api/destinations
    [HttpGet]
    public ActionResult<IEnumerable<Destination>> Get(string country, string city, int rating)
    {

      var query = _db.Destinations.AsQueryable();

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (rating != 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      return query.ToList();
    }
    //http://locahost:5000/api/destinations?api-version=2.0
    [ApiVersion("2.0")]
    [Route("api/{v:apiVersion}/destinations")]
    [ApiController]
    public class DestinationsV2Controller : ControllerBase
    {
      private TravelAPIContext _db;

      public DestinationsV2Controller(TravelAPIContext db)
      {
        _db = db;
      }

      // GET api/destinations
      [HttpGet]
      public ActionResult<IEnumerable<Destination>> Get(string country, string city, int rating)
      {

        var query = _db.Destinations.AsQueryable();

        if (country != null)
        {
          query = query.Where(entry => entry.Country == country);
        }

        if (city != null)
        {
          query = query.Where(entry => entry.City == city);
        }

        if (rating != 0)
        {
          query = query.Where(entry => entry.Rating == rating);
        }
        return query.ToList();
      }

    }

    // // Post api/destinations
    // [HttpPost]
    // public void Post([FromBody] Destination destination)
    // {
    //     _db.Destinations.Add(destination);
    //     _db.SaveChanges();
    // }

    // // GET api/destination/id
    // [HttpGet("{id}")]
    // public ActionResult<Destination> Get(int id)
    // {
    //     return _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
    // }

    // //PUT api/destination/id
    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] Destination destination)
    // {
    //     destination.DestinationId = id;
    //     _db.Entry(destination).State = EntityState.Modified;
    //     _db.SaveChanges();
    // }

    // // DELETE api/destinations/id
    // [HttpDelete("{id}")]
    // public void Delete(int id)
    // {
    //     var destinationToDelete = _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
    //     _db.Destinations.Remove(destinationToDelete);
    //     _db.SaveChanges();
    // }

  }
}
