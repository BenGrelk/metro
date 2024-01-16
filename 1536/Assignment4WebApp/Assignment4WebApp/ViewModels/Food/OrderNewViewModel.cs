using Assignment4WebApp.Models.View;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment4WebApp.ViewModels.Food;

public class OrderNewViewModel
{
    public Order? Order { get; init; } = new();

// List of types for a dropdown control
// Each list will be populated by the view functions using LINQ
    public List<SelectListItem> BeverageList { get; set; } = new();
    public List<SelectListItem> AppetizerList { get; set; } = new();
    public List<SelectListItem> MainCourseList { get; set; } = new();
    public List<SelectListItem> DessertList { get; set; } = new();
    public string Message { get; set; } = string.Empty;
}