using Assignment4WebApp.FoodFunctions;
using Assignment4WebApp.Models.Data;

namespace Assignment4WebApp.ViewModels.Food;

public class IndexViewModel
{
    public List<FoodItemEntity> FoodList { get; init; } = FoodViewFunctions.GetFoodList();
    public List<OrderEntity> OrderList { get; init; } = FoodViewFunctions.GetOrderList();
}