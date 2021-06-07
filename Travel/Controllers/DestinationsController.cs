using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private readonly TravelContext _db;
    public DestinationsController(TravelContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> Get(string destinationName, string category, int rating)
    {
      var query = _db.Destinations.AsQueryable();

      if (destinationName != null)
      {
        query = query.Where(entry => entry.DestinationName == destinationName);
      }
      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }
      if (rating >= 1 && rating <= 5)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
      var destination = await _db.Destinations.FindAsync(id);

      if (destination == null)
      {
        return NotFound(); // inherent method to c#?
      }
      return destination;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Destination destination)
    {
      if (id != destination.DestinationId)
      {
        return BadRequest();
      }
      _db.Entry(destination).State = EntityState.Modified; // WUT?

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DestinationExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Destination>> PostDestination(Destination destination)
    {
      _db.Destinations.Add(destination);
      await _db.SaveChangesAsync();

      return CreatedAtAction("GetDestination", new { id = destination.DestinationId }, destination);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDestination(int id)
    {
      var destination = await _db.Destinations.FindAsync(id);
      if (destination == null)
      {
        return NotFound();
      }

      _db.Destinations.Remove(destination);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool DestinationExists(int id)
    {
      return _db.Destinations.Any(e => e.DestinationId == id);
    }

  }
}