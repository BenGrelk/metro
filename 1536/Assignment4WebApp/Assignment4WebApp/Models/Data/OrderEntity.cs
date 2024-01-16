using System.ComponentModel.DataAnnotations;
using Assignment4WebApp.FoodFunctions;

namespace Assignment4WebApp.Models.Data;

public class OrderEntity
{
    [Key]
    public string OrderId { get; init; } = FoodViewFunctions.GetOrderList().ToString() ?? throw new InvalidOperationException();

    public decimal OrderTotal { get; set; }
    public string? BeverageItem { get; set; }
    public string? AppetizerItem { get; set; }
    public string? MainCourseItem { get; set; }
    public string? DessertItem { get; set; }
}