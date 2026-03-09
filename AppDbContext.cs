using Microsoft.EntityFrameworkCore;
using FoodPickerAPI.Models;

namespace FoodPickerAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Food> Foods { get; set; }
    public DbSet<Favourite> Favourites { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>().HasData(
            new Food { Id = 1, Name = "Margherita Pizza", Cuisine = "Italian", Mood = "comfort,cheesy", Calories = 266, Protein = "11g", Carbs = "33g", Fat = "10g", Emoji = "🍕" },
            new Food { Id = 2, Name = "Chicken Biryani", Cuisine = "South Asian", Mood = "hearty,spicy", Calories = 490, Protein = "28g", Carbs = "55g", Fat = "14g", Emoji = "🍛" },
            new Food { Id = 3, Name = "Sushi Rolls", Cuisine = "Japanese", Mood = "light,fresh", Calories = 200, Protein = "9g", Carbs = "38g", Fat = "2g", Emoji = "🍣" },
            new Food { Id = 4, Name = "Beef Tacos", Cuisine = "Mexican", Mood = "comfort,spicy", Calories = 350, Protein = "21g", Carbs = "28g", Fat = "16g", Emoji = "🌮" },
            new Food { Id = 5, Name = "Caesar Salad", Cuisine = "American", Mood = "light,healthy", Calories = 180, Protein = "8g", Carbs = "14g", Fat = "11g", Emoji = "🥗" },
            new Food { Id = 6, Name = "Pad Thai", Cuisine = "Thai", Mood = "hearty,sweet", Calories = 400, Protein = "20g", Carbs = "52g", Fat = "11g", Emoji = "🍜" },
            new Food { Id = 7, Name = "Butter Chicken", Cuisine = "South Asian", Mood = "comfort,hearty", Calories = 438, Protein = "26g", Carbs = "12g", Fat = "32g", Emoji = "🍗" },
            new Food { Id = 8, Name = "Greek Salad", Cuisine = "Mediterranean", Mood = "light,fresh", Calories = 150, Protein = "5g", Carbs = "10g", Fat = "11g", Emoji = "🥙" },
            new Food { Id = 9, Name = "Ramen", Cuisine = "Japanese", Mood = "comfort,hearty", Calories = 436, Protein = "22g", Carbs = "60g", Fat = "12g", Emoji = "🍜" },
            new Food { Id = 10, Name = "Cheeseburger", Cuisine = "American", Mood = "comfort,cheesy", Calories = 535, Protein = "28g", Carbs = "40g", Fat = "29g", Emoji = "🍔" },
            new Food { Id = 11, Name = "Falafel Wrap", Cuisine = "Mediterranean", Mood = "light,healthy", Calories = 320, Protein = "12g", Carbs = "42g", Fat = "13g", Emoji = "🧆" },
            new Food { Id = 12, Name = "Tom Yum Soup", Cuisine = "Thai", Mood = "light,spicy", Calories = 100, Protein = "8g", Carbs = "6g", Fat = "3g", Emoji = "🍲" },
            new Food { Id = 13, Name = "Pasta Carbonara", Cuisine = "Italian", Mood = "comfort,cheesy", Calories = 510, Protein = "22g", Carbs = "58g", Fat = "21g", Emoji = "🍝" },
            new Food { Id = 14, Name = "Fish & Chips", Cuisine = "British", Mood = "hearty,comfort", Calories = 595, Protein = "27g", Carbs = "60g", Fat = "28g", Emoji = "🐟" },
            new Food { Id = 15, Name = "Acai Bowl", Cuisine = "American", Mood = "fresh,healthy", Calories = 210, Protein = "5g", Carbs = "40g", Fat = "6g", Emoji = "🫐" }
        );
    }
}
