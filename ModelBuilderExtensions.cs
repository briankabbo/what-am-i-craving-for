using Microsoft.EntityFrameworkCore;
using FoodPickerAPI.Models;

namespace FoodPickerAPI.Data;

public static class ModelBuilderExtensions
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>().HasData(
            new Food { Id = 1, Name = "Margherita Pizza", Cuisine = "Italian", Moods = "Happy,Romantic", TasteProfile = "savory,rich", CuisineType = "Global", Calories = 266, ProteinG = 11, CarbsG = 33, FatG = 10, Emoji = "🍕" },
            new Food { Id = 2, Name = "Chicken Biryani", Cuisine = "South Asian", Moods = "Happy,Hungry", TasteProfile = "spicy,rich", CuisineType = "Asian", Calories = 490, ProteinG = 28, CarbsG = 55, FatG = 14, Emoji = "🍛" },
            new Food { Id = 3, Name = "Sushi Rolls", Cuisine = "Japanese", Moods = "Romantic,Lazy", TasteProfile = "umami,fresh", CuisineType = "Asian", Calories = 200, ProteinG = 9, CarbsG = 38, FatG = 2, Emoji = "🍣" },
            new Food { Id = 4, Name = "Beef Tacos", Cuisine = "Mexican", Moods = "Happy,Hungry", TasteProfile = "spicy,savory", CuisineType = "Global", Calories = 350, ProteinG = 21, CarbsG = 28, FatG = 16, Emoji = "🌮" },
            new Food { Id = 5, Name = "Caesar Salad", Cuisine = "American", Moods = "Sad,Tired", TasteProfile = "savory,fresh", CuisineType = "Global", Calories = 180, ProteinG = 8, CarbsG = 14, FatG = 11, Emoji = "🥗" },
            new Food { Id = 6, Name = "Pad Thai", Cuisine = "Thai", Moods = "Happy,Stressed", TasteProfile = "sweet,salty", CuisineType = "Asian", Calories = 400, ProteinG = 20, CarbsG = 52, FatG = 11, Emoji = "🍜" },
            new Food { Id = 7, Name = "Butter Chicken", Cuisine = "South Asian", Moods = "Stressed,Hungry", TasteProfile = "rich,creamy", CuisineType = "Asian", Calories = 438, ProteinG = 26, CarbsG = 12, FatG = 32, Emoji = "🍗" },
            new Food { Id = 8, Name = "Greek Salad", Cuisine = "Mediterranean", Moods = "Sad,Tired", TasteProfile = "fresh,tangy", CuisineType = "Global", Calories = 150, ProteinG = 5, CarbsG = 10, FatG = 11, Emoji = "🥙" },
            new Food { Id = 9, Name = "Ramen", Cuisine = "Japanese", Moods = "Stressed,Tired", TasteProfile = "umami,rich", CuisineType = "Asian", Calories = 436, ProteinG = 22, CarbsG = 60, FatG = 12, Emoji = "🍜" },
            new Food { Id = 10, Name = "Cheeseburger", Cuisine = "American", Moods = "Happy,Hungry", TasteProfile = "savory,rich", CuisineType = "Global", Calories = 535, ProteinG = 28, CarbsG = 40, FatG = 29, Emoji = "🍔" },
            new Food { Id = 11, Name = "Falafel Wrap", Cuisine = "Mediterranean", Moods = "Tired,Lazy", TasteProfile = "savory,earthy", CuisineType = "Global", Calories = 320, ProteinG = 12, CarbsG = 42, FatG = 13, Emoji = "🧆" },
            new Food { Id = 12, Name = "Tom Yum Soup", Cuisine = "Thai", Moods = "Sad,Tired", TasteProfile = "spicy,sour", CuisineType = "Asian", Calories = 100, ProteinG = 8, CarbsG = 6, FatG = 3, Emoji = "🍲" },
            new Food { Id = 13, Name = "Pasta Carbonara", Cuisine = "Italian", Moods = "Romantic,Stressed", TasteProfile = "rich,creamy", CuisineType = "Global", Calories = 510, ProteinG = 22, CarbsG = 58, FatG = 21, Emoji = "🍝" },
            new Food { Id = 14, Name = "Fish & Chips", Cuisine = "British", Moods = "Hungry,Lazy", TasteProfile = "savory,fried", CuisineType = "Global", Calories = 595, ProteinG = 27, CarbsG = 60, FatG = 28, Emoji = "🐟" },
            new Food { Id = 15, Name = "Acai Bowl", Cuisine = "American", Moods = "Happy,Sad", TasteProfile = "sweet,fresh", CuisineType = "Global", Calories = 210, ProteinG = 5, CarbsG = 40, FatG = 6, Emoji = "🫐" }
        );
    }
}
