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
        var favs = await _db.Favourites
            .Include(f => f.Food)
            .ToListAsync();
        return Ok(favs);
    }

    // POST /api/favourites
    // Body: { "foodId": 5 }
    [HttpPost]
    public async Task<IActionResult> AddFavourite([FromBody] Favourite fav)
    {
        // Validate the FoodId actually exists
        var foodExists = await _db.Foods.AnyAsync(f => f.Id == fav.FoodId);
        if (!foodExists)
            return NotFound(new { message = $"Food with id {fav.FoodId} does not exist." });

        // Check for duplicate
        var alreadyFavourited = await _db.Favourites.AnyAsync(f => f.FoodId == fav.FoodId);
        if (alreadyFavourited)
            return Conflict(new { message = "Already in favourites." });

        _db.Favourites.Add(fav);
        await _db.SaveChangesAsync();

        // Return the favourite with food details included
        var created = await _db.Favourites
            .Include(f => f.Food)
            .FirstAsync(f => f.Id == fav.Id);

        return CreatedAtAction(nameof(GetFavourites), new { id = created.Id }, created);
    }

    // DELETE /api/favourites/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveFavourite(int id)
    {
        var fav = await _db.Favourites.FindAsync(id);
        if (fav == null)
            return NotFound(new { message = $"Favourite with id {id} not found." });

        _db.Favourites.Remove(fav);
        await _db.SaveChangesAsync();
        return NoContent();
    }

    // GET /api/favourites/check/{foodId}
    // Check if a specific food is already favourited
    [HttpGet("check/{foodId}")]
    public async Task<IActionResult> CheckFavourite(int foodId)
    {
        var isFavourite = await _db.Favourites.AnyAsync(f => f.FoodId == foodId);
        return Ok(new { foodId, isFavourite });
    }
}
