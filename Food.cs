namespace FoodPickerAPI.Models;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Cuisine { get; set; } = string.Empty;
    public string Mood { get; set; } = string.Empty; // comma-separated e.g. "comfort,spicy"
    public int Calories { get; set; }
    public string Protein { get; set; } = string.Empty;
    public string Carbs { get; set; } = string.Empty;
    public string Fat { get; set; } = string.Empty;
    public string Emoji { get; set; } = string.Empty;
}
