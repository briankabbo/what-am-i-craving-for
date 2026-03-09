using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodPickerAPI.Data;
using FoodPickerAPI.Models;

namespace FoodPickerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FoodsController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly Random _random = new();

    public FoodsController(AppDbContext db)
    {
        _db = db;
    }

    // GET /api/foods?cuisine=Italian&mood=comfort
    [HttpGet]
    public async Task<IActionResult> GetFoods([FromQuery] string? cuisine, [FromQuery] string? mood)
    {
        var query = _db.Foods.AsQueryable();

        if (!string.IsNullOrEmpty(cuisine) && cuisine != "All")
            query = query.Where(f => f.Cuisine == cuisine);

        if (!string.IsNullOrEmpty(mood) && mood != "All")
            query = query.Where(f => f.Mood.Contains(mood));

        return Ok(await query.ToListAsync());
    }

    // GET /api/foods/random?cuisine=Italian&mood=comfort
    [HttpGet("random")]
    public async Task<IActionResult> GetRandom([FromQuery] string? cuisine, [FromQuery] string? mood)
    {
        var query = _db.Foods.AsQueryable();

        if (!string.IsNullOrEmpty(cuisine) && cuisine != "All")
            query = query.Where(f => f.Cuisine == cuisine);

        if (!string.IsNullOrEmpty(mood) && mood != "All")
            query = query.Where(f => f.Mood.Contains(mood));

        var foods = await query.ToListAsync();

        if (foods.Count == 0)
            return NotFound(new { message = "No foods found matching your filters." });

        var picked = foods[_random.Next(foods.Count)];
        return Ok(picked);
    }
}
