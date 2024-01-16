using Assignment4WebApp.Models.View;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment4WebApp.ViewModels.Food;

public class OrderEditViewModel
{
    public Order? Order { get; init; } = new();
    public string Message { get; set; } = string.Empty;

    public List<SelectListItem> BeverageList { get; set; } = new();
    public List<SelectListItem> AppetizerList { get; set; } = new();
    public List<SelectListItem> MainCourseList { get; set; } = new();
    public List<SelectListItem> DessertList { get; set; } = new();
}