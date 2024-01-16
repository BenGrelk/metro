using System.ComponentModel.DataAnnotations;
using Assignment4WebApp.FoodFunctions;

namespace Assignment4WebApp.Models.View;

public class Order
{
    public string OrderId { get; init; } = FoodViewFunctions.GetNewOrderId();
    public decimal OrderTotal { get; set; }
    [Required] public string? BeverageItem { get; init; }
    [Required] public string? AppetizerItem { get; init; }
    [Required] public string? MainCourseItem { get; init; }
    [Required] public string? DessertItem { get; init; }
}