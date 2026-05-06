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
                Calories = 360, Protein = "5g", Carbs = "72g", Fat = "8g", Emoji = "🥭"
            },
            new Food
            {
                Id = 2, Name = "Bibimbap", Cuisine = "Korean", CuisineType = "Asian",
                Moods = "Happy", TasteProfile = "umami,bold,colourful",
                Calories = 490, Protein = "25g", Carbs = "75g", Fat = "16g", Emoji = "🍚"
            },
            new Food
            {
                Id = 3, Name = "Margherita Pizza", Cuisine = "Italian", CuisineType = "Global",
                Moods = "Happy,Lazy", TasteProfile = "sweet,cheesy,bold",
                Calories = 266, Protein = "11g", Carbs = "33g", Fat = "10g", Emoji = "🍕"
            },
            new Food
            {
                Id = 4, Name = "Beef Tacos", Cuisine = "Mexican", CuisineType = "Global",
                Moods = "Happy", TasteProfile = "bold,spicy,fun",
                Calories = 350, Protein = "21g", Carbs = "28g", Fat = "16g", Emoji = "🌮"
            },

            // SAD? Warm · Soft · Serotonin seeking

            new Food
            {
                Id = 5, Name = "Ramen", Cuisine = "Japanese", CuisineType = "Asian",
                Moods = "Sad,Tired", TasteProfile = "umami,warm,soft",
                Calories = 436, Protein = "22g", Carbs = "60g", Fat = "12g", Emoji = "🍜"
            },
            new Food
            {
                Id = 6, Name = "Khichdi", Cuisine = "South Asian", CuisineType = "Asian",
                Moods = "Sad,Tired", TasteProfile = "mild,warm,soft",
                Calories = 210, Protein = "9g", Carbs = "38g", Fat = "4g", Emoji = "🍲"
            },
            new Food
            {
                Id = 7, Name = "Mac & Cheese", Cuisine = "American", CuisineType = "Global",
                Moods = "Sad,Lazy", TasteProfile = "sweet,cheesy,carb-rich",
                Calories = 350, Protein = "14g", Carbs = "40g", Fat = "14g", Emoji = "🧀"
            },
            new Food
            {
                Id = 8, Name = "Chocolate Lava Cake", Cuisine = "French", CuisineType = "Global",
                Moods = "Sad,Romantic", TasteProfile = "bittersweet,warm,rich",
                Calories = 380, Protein = "5g", Carbs = "40g", Fat = "22g", Emoji = "🍫"
            },

            
            // STRESSED? Salty · Crunchy · Cortisol-relief

            new Food
            {
                Id = 9, Name = "Tteokbokki", Cuisine = "Korean", CuisineType = "Asian",
                Moods = "Stressed,Bored", TasteProfile = "spicy,chewy,sweet",
                Calories = 280, Protein = "7g", Carbs = "54g", Fat = "4g", Emoji = "🍢"
            },
            new Food
            {
                Id = 10, Name = "Tom Yum Soup", Cuisine = "Thai", CuisineType = "Asian",
                Moods = "Stressed", TasteProfile = "spicy,sour,warm",
                Calories = 180, Protein = "20g", Carbs = "10g", Fat = "5g", Emoji = "🍲"
            },
            new Food
            {
                Id = 11, Name = "Nachos", Cuisine = "Mexican", CuisineType = "Global",
                Moods = "Stressed,Bored", TasteProfile = "salty,crunchy,cheesy",
                Calories = 480, Protein = "14g", Carbs = "52g", Fat = "24g", Emoji = "🧆"
            },
            new Food
            {
                Id = 12, Name = "Hummus & Pita", Cuisine = "Middle Eastern", CuisineType = "Global",
                Moods = "Stressed", TasteProfile = "salty,earthy,light",
                Calories = 320, Protein = "11g", Carbs = "40g", Fat = "12g", Emoji = "🥙"
            },

            
            // TIRED? Warm · Easy · Umami-rich

            new Food
            {
                Id = 13, Name = "Pho", Cuisine = "Vietnamese", CuisineType = "Asian",
                Moods = "Tired", TasteProfile = "warm,umami,light",
                Calories = 400, Protein = "27g", Carbs = "48g", Fat = "10g", Emoji = "🍜"
            },
            new Food
            {
                Id = 14, Name = "Butter Chicken", Cuisine = "South Asian", CuisineType = "Asian",
                Moods = "Tired,Sad", TasteProfile = "warm,rich,soft",
                Calories = 438, Protein = "26g", Carbs = "12g", Fat = "32g", Emoji = "🍗"
            },
            new Food
            {
                Id = 15, Name = "Pasta Carbonara", Cuisine = "Italian", CuisineType = "Global",
                Moods = "Tired,Lazy", TasteProfile = "rich,warm,soft",
                Calories = 510, Protein = "22g", Carbs = "58g", Fat = "21g", Emoji = "🍝"
            },
            new Food
            {
                Id = 16, Name = "Chicken Noodle Soup", Cuisine = "American", CuisineType = "Global",
                Moods = "Tired,Sad", TasteProfile = "warm,mild,light",
                Calories = 180, Protein = "14g", Carbs = "20g", Fat = "4g", Emoji = "🥣"
            },

            
            // BORED? Snackable · Novel · Stimulating

            new Food
            {
                Id = 17, Name = "Takoyaki", Cuisine = "Japanese", CuisineType = "Asian",
                Moods = "Bored", TasteProfile = "umami,savoury,fun",
                Calories = 350, Protein = "14g", Carbs = "42g", Fat = "12g", Emoji = "🐙"
            },
            new Food
            {
                Id = 18, Name = "Korean Fried Chicken", Cuisine = "Korean", CuisineType = "Asian",
                Moods = "Bored,Happy", TasteProfile = "salty,crunchy,sweet",
                Calories = 490, Protein = "30g", Carbs = "28g", Fat = "26g", Emoji = "🍗"
            },
            new Food
            {
                Id = 19, Name = "Loaded Fries", Cuisine = "American", CuisineType = "Global",
                Moods = "Bored,Lazy", TasteProfile = "salty,crunchy,cheesy",
                Calories = 520, Protein = "12g", Carbs = "58g", Fat = "26g", Emoji = "🍟"
            },
            new Food
            {
                Id = 20, Name = "Churros", Cuisine = "Spanish", CuisineType = "Global",
                Moods = "Bored,Happy", TasteProfile = "sweet,crunchy,fun",
                Calories = 310, Protein = "4g", Carbs = "40g", Fat = "15g", Emoji = "🍩"
            },

            
            // ROMANTIC? Rich · Elegant · Shareable

            new Food
            {
                Id = 21, Name = "Sushi Platter", Cuisine = "Japanese", CuisineType = "Asian",
                Moods = "Romantic", TasteProfile = "umami,delicate,elegant",
                Calories = 480, Protein = "24g", Carbs = "62g", Fat = "14g", Emoji = "🍣"
            },
            new Food
            {
                Id = 22, Name = "Peking Duck", Cuisine = "Chinese", CuisineType = "Asian",
                Moods = "Romantic,Hungry", TasteProfile = "rich,crispy,umami",
                Calories = 470, Protein = "28g", Carbs = "20g", Fat = "30g", Emoji = "🦆"
            },
            new Food
            {
                Id = 23, Name = "Tiramisu", Cuisine = "Italian", CuisineType = "Global",
                Moods = "Romantic,Happy", TasteProfile = "bittersweet,rich,creamy",
                Calories = 400, Protein = "7g", Carbs = "42g", Fat = "22g", Emoji = "🍰"
            },
            new Food
            {
                Id = 24, Name = "Beef Bourguignon", Cuisine = "French", CuisineType = "Global",
                Moods = "Romantic", TasteProfile = "rich,umami,hearty",
                Calories = 440, Protein = "32g", Carbs = "18g", Fat = "22g", Emoji = "🥩"
            },

            
            // HUNGRY? Hearty · Filling · Protein-rich

            new Food
            {
                Id = 25, Name = "Chicken Biryani", Cuisine = "South Asian", CuisineType = "Asian",
                Moods = "Hungry", TasteProfile = "spicy,hearty,aromatic",
                Calories = 490, Protein = "28g", Carbs = "55g", Fat = "14g", Emoji = "🍛"
            },
            new Food
            {
                Id = 26, Name = "Nasi Lemak", Cuisine = "Malaysian", CuisineType = "Asian",
                Moods = "Hungry", TasteProfile = "rich,spicy,filling",
                Calories = 500, Protein = "22g", Carbs = "48g", Fat = "22g", Emoji = "🍱"
            },
            new Food
            {
                Id = 27, Name = "Cheeseburger", Cuisine = "American", CuisineType = "Global",
                Moods = "Hungry,Bored", TasteProfile = "savoury,rich,hearty",
                Calories = 535, Protein = "28g", Carbs = "40g", Fat = "29g", Emoji = "🍔"
            },
            new Food
            {
                Id = 28, Name = "Shawarma", Cuisine = "Middle Eastern", CuisineType = "Global",
                Moods = "Hungry", TasteProfile = "spicy,savoury,filling",
                Calories = 450, Protein = "28g", Carbs = "38g", Fat = "18g", Emoji = "🌯"
            },

            
            // LAZY? Familiar · Easy · No-effort

            new Food
            {
                Id = 29, Name = "Fried Rice", Cuisine = "Chinese", CuisineType = "Asian",
                Moods = "Lazy,Tired", TasteProfile = "savoury,familiar,easy",
                Calories = 380, Protein = "12g", Carbs = "52g", Fat = "14g", Emoji = "🍳"
            },
            new Food
            {
                Id = 30, Name = "Pad Thai", Cuisine = "Thai", CuisineType = "Asian",
                Moods = "Lazy", TasteProfile = "sweet,savoury,familiar",
                Calories = 400, Protein = "20g", Carbs = "52g", Fat = "11g", Emoji = "🍜"
            },
            new Food
            {
                Id = 31, Name = "Grilled Cheese Sandwich", Cuisine = "American", CuisineType = "Global",
                Moods = "Lazy,Sad", TasteProfile = "cheesy,warm,simple",
                Calories = 380, Protein = "14g", Carbs = "30g", Fat = "22g", Emoji = "🥪"
            },
            new Food
            {
                Id = 32, Name = "Shakshuka", Cuisine = "Middle Eastern", CuisineType = "Global",
                Moods = "Lazy", TasteProfile = "savoury,warm,easy",
                Calories = 220, Protein = "12g", Carbs = "16g", Fat = "12g", Emoji = "🍳"
            }
        );
    }
}
