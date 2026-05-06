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

            // HAPPY? Sweet · Bold · Celebratory

            new Food
            {
                Id = 1, Name = "Mango Sticky Rice", Cuisine = "Thai", CuisineType = "Asian",
                Moods = "Happy", TasteProfile = "sweet,rich,creamy",
                Calories = 360, ProteinG = 5, CarbsG = 72, FatG = 8, Emoji = "🥭"
            },
            new Food
            {
                Id = 2, Name = "Bibimbap", Cuisine = "Korean", CuisineType = "Asian",
                Moods = "Happy", TasteProfile = "umami,bold,colourful",
                Calories = 490, ProteinG = 25, CarbsG = 75, FatG = 16, Emoji = "🍚"
            },
            new Food
            {
                Id = 3, Name = "Margherita Pizza", Cuisine = "Italian", CuisineType = "Global",
                Moods = "Happy,Lazy", TasteProfile = "sweet,cheesy,bold",
                Calories = 266, ProteinG = 11, CarbsG = 33, FatG = 10, Emoji = "🍕"
            },
            new Food
            {
                Id = 4, Name = "Beef Tacos", Cuisine = "Mexican", CuisineType = "Global",
                Moods = "Happy", TasteProfile = "bold,spicy,fun",
                Calories = 350, ProteinG = 21, CarbsG = 28, FatG = 16, Emoji = "🌮"
            },

            // SAD? Warm · Soft · Serotonin-seeking

            new Food
            {
                Id = 5, Name = "Ramen", Cuisine = "Japanese", CuisineType = "Asian",
                Moods = "Sad,Tired", TasteProfile = "umami,warm,soft",
                Calories = 436, ProteinG = 22, CarbsG = 60, FatG = 12, Emoji = "🍜"
            },
            new Food
            {
                Id = 6, Name = "Khichdi", Cuisine = "South Asian", CuisineType = "Asian",
                Moods = "Sad,Tired", TasteProfile = "mild,warm,soft",
                Calories = 210, ProteinG = 9, CarbsG = 38, FatG = 4, Emoji = "🍲"
            },
            new Food
            {
                Id = 7, Name = "Mac & Cheese", Cuisine = "American", CuisineType = "Global",
                Moods = "Sad,Lazy", TasteProfile = "sweet,cheesy,carb-rich",
                Calories = 350, ProteinG = 14, CarbsG = 40, FatG = 14, Emoji = "🧀"
            },
            new Food
            {
                Id = 8, Name = "Chocolate Lava Cake", Cuisine = "French", CuisineType = "Global",
                Moods = "Sad,Romantic", TasteProfile = "bittersweet,warm,rich",
                Calories = 380, ProteinG = 5, CarbsG = 40, FatG = 22, Emoji = "🍫"
            },

            
            // STRESSED? Salty · Crunchy · Cortisol-relief

            new Food
            {
                Id = 9, Name = "Tteokbokki", Cuisine = "Korean", CuisineType = "Asian",
                Moods = "Stressed,Bored", TasteProfile = "spicy,chewy,sweet",
                Calories = 280, ProteinG = 7, CarbsG = 54, FatG = 4, Emoji = "🍢"
            },
            new Food
            {
                Id = 10, Name = "Tom Yum Soup", Cuisine = "Thai", CuisineType = "Asian",
                Moods = "Stressed", TasteProfile = "spicy,sour,warm",
                Calories = 180, ProteinG = 20, CarbsG = 10, FatG = 5, Emoji = "🍲"
            },
            new Food
            {
                Id = 11, Name = "Nachos", Cuisine = "Mexican", CuisineType = "Global",
                Moods = "Stressed,Bored", TasteProfile = "salty,crunchy,cheesy",
                Calories = 480, ProteinG = 14, CarbsG = 52, FatG = 24, Emoji = "🧆"
            },
            new Food
            {
                Id = 12, Name = "Hummus & Pita", Cuisine = "Middle Eastern", CuisineType = "Global",
                Moods = "Stressed", TasteProfile = "salty,earthy,light",
                Calories = 320, ProteinG = 11, CarbsG = 40, FatG = 12, Emoji = "🥙"
            },

            
            // TIRED? Warm · Easy · Umami-rich

            new Food
            {
                Id = 13, Name = "Pho", Cuisine = "Vietnamese", CuisineType = "Asian",
                Moods = "Tired", TasteProfile = "warm,umami,light",
                Calories = 400, ProteinG = 27, CarbsG = 48, FatG = 10, Emoji = "🍜"
            },
            new Food
            {
                Id = 14, Name = "Butter Chicken", Cuisine = "South Asian", CuisineType = "Asian",
                Moods = "Tired,Sad", TasteProfile = "warm,rich,soft",
                Calories = 438, ProteinG = 26, CarbsG = 12, FatG = 32, Emoji = "🍗"
            },
            new Food
            {
                Id = 15, Name = "Pasta Carbonara", Cuisine = "Italian", CuisineType = "Global",
                Moods = "Tired,Lazy", TasteProfile = "rich,warm,soft",
                Calories = 510, ProteinG = 22, CarbsG = 58, FatG = 21, Emoji = "🍝"
            },
            new Food
            {
                Id = 16, Name = "Chicken Noodle Soup", Cuisine = "American", CuisineType = "Global",
                Moods = "Tired,Sad", TasteProfile = "warm,mild,light",
                Calories = 180, ProteinG = 14, CarbsG = 20, FatG = 4, Emoji = "🥣"
            },

            
            // BORED? Snackable · Novel · Stimulating

            new Food
            {
                Id = 17, Name = "Takoyaki", Cuisine = "Japanese", CuisineType = "Asian",
                Moods = "Bored", TasteProfile = "umami,savoury,fun",
                Calories = 350, ProteinG = 14, CarbsG = 42, FatG = 12, Emoji = "🐙"
            },
            new Food
            {
                Id = 18, Name = "Korean Fried Chicken", Cuisine = "Korean", CuisineType = "Asian",
                Moods = "Bored,Happy", TasteProfile = "salty,crunchy,sweet",
                Calories = 490, ProteinG = 30, CarbsG = 28, FatG = 26, Emoji = "🍗"
            },
            new Food
            {
                Id = 19, Name = "Loaded Fries", Cuisine = "American", CuisineType = "Global",
                Moods = "Bored,Lazy", TasteProfile = "salty,crunchy,cheesy",
                Calories = 520, ProteinG = 12, CarbsG = 58, FatG = 26, Emoji = "🍟"
            },
            new Food
            {
                Id = 20, Name = "Churros", Cuisine = "Spanish", CuisineType = "Global",
                Moods = "Bored,Happy", TasteProfile = "sweet,crunchy,fun",
                Calories = 310, ProteinG = 4, CarbsG = 40, FatG = 15, Emoji = "🍩"
            },

            
            // ROMANTIC? Rich · Elegant · Shareable

            new Food
            {
                Id = 21, Name = "Sushi Platter", Cuisine = "Japanese", CuisineType = "Asian",
                Moods = "Romantic", TasteProfile = "umami,delicate,elegant",
                Calories = 480, ProteinG = 24, CarbsG = 62, FatG = 14, Emoji = "🍣"
            },
            new Food
            {
                Id = 22, Name = "Peking Duck", Cuisine = "Chinese", CuisineType = "Asian",
                Moods = "Romantic,Hungry", TasteProfile = "rich,crispy,umami",
                Calories = 470, ProteinG = 28, CarbsG = 20, FatG = 30, Emoji = "🦆"
            },
            new Food
            {
                Id = 23, Name = "Tiramisu", Cuisine = "Italian", CuisineType = "Global",
                Moods = "Romantic,Happy", TasteProfile = "bittersweet,rich,creamy",
                Calories = 400, ProteinG = 7, CarbsG = 42, FatG = 22, Emoji = "🍰"
            },
            new Food
            {
                Id = 24, Name = "Beef Bourguignon", Cuisine = "French", CuisineType = "Global",
                Moods = "Romantic", TasteProfile = "rich,umami,hearty",
                Calories = 440, ProteinG = 32, CarbsG = 18, FatG = 22, Emoji = "🥩"
            },

            
            // HUNGRY? Hearty · Filling · Protein-rich

            new Food
            {
                Id = 25, Name = "Chicken Biryani", Cuisine = "South Asian", CuisineType = "Asian",
                Moods = "Hungry", TasteProfile = "spicy,hearty,aromatic",
                Calories = 490, ProteinG = 28, CarbsG = 55, FatG = 14, Emoji = "🍛"
            },
            new Food
            {
                Id = 26, Name = "Nasi Lemak", Cuisine = "Malaysian", CuisineType = "Asian",
                Moods = "Hungry", TasteProfile = "rich,spicy,filling",
                Calories = 500, ProteinG = 22, CarbsG = 48, FatG = 22, Emoji = "🍱"
            },
            new Food
            {
                Id = 27, Name = "Cheeseburger", Cuisine = "American", CuisineType = "Global",
                Moods = "Hungry,Bored", TasteProfile = "savoury,rich,hearty",
                Calories = 535, ProteinG = 28, CarbsG = 40, FatG = 29, Emoji = "🍔"
            },
            new Food
            {
                Id = 28, Name = "Shawarma", Cuisine = "Middle Eastern", CuisineType = "Global",
                Moods = "Hungry", TasteProfile = "spicy,savoury,filling",
                Calories = 450, ProteinG = 28, CarbsG = 38, FatG = 18, Emoji = "🌯"
            },

            
            // LAZY? Familiar · Easy · No-effort

            new Food
            {
                Id = 29, Name = "Fried Rice", Cuisine = "Chinese", CuisineType = "Asian",
                Moods = "Lazy,Tired", TasteProfile = "savoury,familiar,easy",
                Calories = 380, ProteinG = 12, CarbsG = 52, FatG = 14, Emoji = "🍳"
            },
            new Food
            {
                Id = 30, Name = "Pad Thai", Cuisine = "Thai", CuisineType = "Asian",
                Moods = "Lazy", TasteProfile = "sweet,savoury,familiar",
                Calories = 400, ProteinG = 20, CarbsG = 52, FatG = 11, Emoji = "🍜"
            },
            new Food
            {
                Id = 31, Name = "Grilled Cheese Sandwich", Cuisine = "American", CuisineType = "Global",
                Moods = "Lazy,Sad", TasteProfile = "cheesy,warm,simple",
                Calories = 380, ProteinG = 14, CarbsG = 30, FatG = 22, Emoji = "🥪"
            },
            new Food
            {
                Id = 32, Name = "Shakshuka", Cuisine = "Middle Eastern", CuisineType = "Global",
                Moods = "Lazy", TasteProfile = "savoury,warm,easy",
                Calories = 220, ProteinG = 12, CarbsG = 16, FatG = 12, Emoji = "🍳"
            }
        );
    }
}
