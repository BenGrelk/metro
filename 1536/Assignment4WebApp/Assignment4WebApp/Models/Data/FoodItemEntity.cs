using System.ComponentModel.DataAnnotations;

namespace Assignment4WebApp.Models.Data;

public class FoodItemEntity
{
    [Key]
    public string? Item { get; init; }

    public string? Category { get; init; }

    public decimal ItemCost { get; init; }
}