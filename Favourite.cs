using System.ComponentModel.DataAnnotations.Schema;

namespace FoodPickerAPI.Models;

public class Favourite
{
    public int Id { get; set; }
    public int FoodId { get; set; }

    [Column(TypeName = "varchar(36)")]
    public string SessionId { get; set; } = string.Empty;
    public Food? Food { get; set; }
}

