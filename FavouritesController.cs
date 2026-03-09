using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodPickerAPI.Data;
using FoodPickerAPI.Models;

namespace FoodPickerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FavouritesController : ControllerBase
{
    private readonly AppDbContext _db;

    public FavouritesController(AppDbContext db)
    {
        _db = db;
    }

    // GET /api/favourites
    [HttpGet]
    public async Task<IActionResult> GetFavourites()
    {
        var favs = await _db.Favourites.Include(f => f.Food).ToListAsync();
        return Ok(favs);
    }

    // POST /api/favourites
    [HttpPost]
    public async Task<IActionResult> AddFavourite([FromBody] Favourite fav)
    {
        var exists = await _db.Favourites.AnyAsync(f => f.FoodId == fav.FoodId);
        if (exists)
            return Conflict(new { message = "Already in favourites." });

        _db.Favourites.Add(fav);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetFavourites), new { id = fav.Id }, fav);
    }

    // DELETE /api/favourites/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveFavourite(int id)
    {
        var fav = await _db.Favourites.FindAsync(id);
        if (fav == null) return NotFound();

        _db.Favourites.Remove(fav);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
