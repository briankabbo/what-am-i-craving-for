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

    public FoodsController(AppDbContext db)
    {
        _db = db;
    }

    // ──────────────────────────────────────────────────────────────
    // GET /api/foods
    // Query params (all optional):
    //   mood         = Happy | Sad | Stressed | Tired | Bored | Romantic | Hungry | Lazy
    //   cuisine      = Thai | Korean | Japanese | South Asian | etc.
    //   cuisineType  = Asian | Global
    //   taste        = sweet | spicy | umami | salty | rich | etc.
    //   maxCalories  = 500  (upper calorie limit)
    //   minProtein   = 20   (minimum protein in grams)
    // ──────────────────────────────────────────────────────────────
    [HttpGet]
    public async Task<IActionResult> GetFoods(
        [FromQuery] string? mood,
        [FromQuery] string? cuisine,
        [FromQuery] string? cuisineType,
        [FromQuery] string? taste,
        [FromQuery] int? maxCalories)
    {
        var query = BuildQuery(mood, cuisine, cuisineType, taste, maxCalories);
        return Ok(await query.ToListAsync());
    }

    // ──────────────────────────────────────────────────────────────
    // GET /api/foods/random
    // Same query params as above — picks one random result
    // ──────────────────────────────────────────────────────────────
    [HttpGet("random")]
    public async Task<IActionResult> GetRandom(
        [FromQuery] string? mood,
        [FromQuery] string? cuisine,
        [FromQuery] string? cuisineType,
        [FromQuery] string? taste,
        [FromQuery] int? maxCalories)
    {
        var query = BuildQuery(mood, cuisine, cuisineType, taste, maxCalories);
        var foods = await query.ToListAsync();

        if (foods.Count == 0)
            return NotFound(new { message = "No foods found matching your filters." });

        var picked = foods[Random.Shared.Next(foods.Count)];
        return Ok(picked);
    }

    // ──────────────────────────────────────────────────────────────
    // GET /api/foods/moods
    // Returns the list of all available moods
    // ──────────────────────────────────────────────────────────────
    [HttpGet("moods")]
    public IActionResult GetMoods()
    {
        var moods = new[]
        {
            new { Name = "Happy",    Emoji = "😊", Description = "Celebratory · upbeat · dopamine-driven" },
            new { Name = "Sad",      Emoji = "😢", Description = "Low · heavy-hearted · serotonin-seeking" },
            new { Name = "Stressed", Emoji = "😤", Description = "Overwhelmed · cortisol-high · need relief" },
            new { Name = "Tired",    Emoji = "😴", Description = "Drained · low energy · need something easy" },
            new { Name = "Bored",    Emoji = "😑", Description = "Restless · low stimulation · want novelty" },
            new { Name = "Romantic", Emoji = "🥰", Description = "Intimate · elegant · oxytocin bonding" },
            new { Name = "Hungry",   Emoji = "🤤", Description = "Ravenous · need fuel · ghrelin-driven" },
            new { Name = "Lazy",     Emoji = "🥱", Description = "Can't be bothered · familiar · no effort" },
        };
        return Ok(moods);
    }

    // ──────────────────────────────────────────────────────────────
    // GET /api/foods/cuisines
    // Returns the list of all distinct cuisines in the database
    // ──────────────────────────────────────────────────────────────
    [HttpGet("cuisines")]
    public async Task<IActionResult> GetCuisines()
    {
        var cuisines = await _db.Foods
            .Select(f => f.Cuisine)
            .Distinct()
            .OrderBy(c => c)
            .ToListAsync();
        return Ok(cuisines);
    }

    // ──────────────────────────────────────────────────────────────
    // GET /api/foods/{id}
    // Returns a single food by ID
    // ──────────────────────────────────────────────────────────────
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var food = await _db.Foods.FindAsync(id);
        if (food == null)
            return NotFound(new { message = $"Food with id {id} not found." });
        return Ok(food);
    }

    // ──────────────────────────────────────────────────────────────
    // Shared filter logic — used by GetFoods and GetRandom
    // ──────────────────────────────────────────────────────────────
    private IQueryable<Food> BuildQuery(
        string? mood,
        string? cuisine,
        string? cuisineType,
        string? taste,
        int? maxCalories)
    {
        var query = _db.Foods.AsQueryable();

        if (!string.IsNullOrWhiteSpace(mood))
            query = query.Where(f => f.Moods.Contains(mood));

        if (!string.IsNullOrWhiteSpace(cuisine))
            query = query.Where(f => f.Cuisine == cuisine);

        if (!string.IsNullOrWhiteSpace(cuisineType))
            query = query.Where(f => f.CuisineType == cuisineType);

        if (!string.IsNullOrWhiteSpace(taste))
            query = query.Where(f => f.TasteProfile.Contains(taste));

        if (maxCalories.HasValue)
            query = query.Where(f => f.Calories <= maxCalories.Value);

        return query;
    }
}
