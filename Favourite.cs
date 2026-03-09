namespace FoodPickerAPI.Models;

public class Favourite
{
    public int Id { get; set; }
    public int FoodId { get; set; }
    public Food? Food { get; set; }
}
