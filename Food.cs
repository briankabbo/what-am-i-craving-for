namespace FoodPickerAPI.Models;

public class Food
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Cuisine { get; set; } = string.Empty;

    // Comma-separated mood tags e.g. "Happy,Romantic"
    // A food can belong to multiple moods
    public string Moods { get; set; } = string.Empty;

    // Taste profile tags e.g. "sweet,rich,creamy"
    public string TasteProfile { get; set; } = string.Empty;

    // Origin type for filtering
    public string CuisineType { get; set; } = string.Empty; // "Asian" or "Global"

    // Nutrition — all numeric now (per standard serving)
    public int Calories { get; set; }
    public int ProteinG { get; set; }   // grams
    public int CarbsG { get; set; }     // grams
    public int FatG { get; set; }       // grams

    public string Emoji { get; set; } = string.Empty;
}
