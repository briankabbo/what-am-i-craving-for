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

    private string? GetSessionId()
    {
        return Request.Headers["X-Session-Id"].FirstOrDefault();
    }

    // GET /api/favourites
    [HttpGet]
    public async Task<IActionResult> GetFavourites()
    {
        var sessionId = GetSessionId();
        if (string.IsNullOrEmpty(sessionId))
            return BadRequest(new { message = "Missing X-Session-Id header." });

        var favs = await _db.Favourites
            .Include(f => f.Food)
            .Where(f => f.SessionId == sessionId)
            .ToListAsync();
        return Ok(favs);
    }

    // POST /api/favourites
    // Body: { "foodId": 5 }
    [HttpPost]
    public async Task<IActionResult> AddFavourite([FromBody] AddFavouriteRequest request)
    {
        var sessionId = GetSessionId();
        if (string.IsNullOrEmpty(sessionId))
            return BadRequest(new { message = "Missing X-Session-Id header." });

        var foodExists = await _db.Foods.AnyAsync(f => f.Id == request.FoodId);
        if (!foodExists)
            return NotFound(new { message = $"Food with id {request.FoodId} does not exist." });

        var alreadyFavourited = await _db.Favourites
            .AnyAsync(f => f.FoodId == request.FoodId && f.SessionId == sessionId);
        if (alreadyFavourited)
            return Conflict(new { message = "Already in favourites." });

        var fav = new Favourite
        {
            FoodId = request.FoodId,
            SessionId = sessionId
        };

        _db.Favourites.Add(fav);
        await _db.SaveChangesAsync();

        var created = await _db.Favourites
            .Include(f => f.Food)
            .FirstAsync(f => f.Id == fav.Id);

        return CreatedAtAction(nameof(GetFavourites), new { id = created.Id }, created);
    }

    // DELETE /api/favourites/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveFavourite(int id)
    {
        var sessionId = GetSessionId();
        if (string.IsNullOrEmpty(sessionId))
            return BadRequest(new { message = "Missing X-Session-Id header." });

        var fav = await _db.Favourites.FindAsync(id);
        if (fav == null || fav.SessionId != sessionId)
            return NotFound(new { message = $"Favourite with id {id} not found." });

        _db.Favourites.Remove(fav);
        await _db.SaveChangesAsync();
        return NoContent();
    }

    // GET /api/favourites/check/{foodId}
    [HttpGet("check/{foodId}")]
    public async Task<IActionResult> CheckFavourite(int foodId)
    {
        var sessionId = GetSessionId();
        if (string.IsNullOrEmpty(sessionId))
            return BadRequest(new { message = "Missing X-Session-Id header." });

        var isFavourite = await _db.Favourites
            .AnyAsync(f => f.FoodId == foodId && f.SessionId == sessionId);
        return Ok(new { foodId, isFavourite });
    }
}