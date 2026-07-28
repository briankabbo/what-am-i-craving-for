namespace FoodPickerAPI.Models;

public class Favourite
{
    public int Id { get; set; }
    public int FoodId { get; set; }
    public string SessionId { get; set; } = string.Empty;
    public Food? Food { get; set; }
}
