using Assignment4WebApp.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment4WebApp.FoodFunctions;

public static class FoodViewFunctions
{
    public static List<FoodItemEntity> GetFoodList()
    {
        return DataLists.FoodList;
    }

    public static List<OrderEntity> GetOrderList()
    {
        return DataLists.OrderList;
    }

    public static string GetNewOrderId()
    {
        return Guid.NewGuid().ToString();
    }

    public static List<SelectListItem> GetBeverageList()
    {
        return DataLists.FoodList
            .Where(f => f.Category == "Beverage")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            })
            .ToList();
    }

    public static List<SelectListItem> GetAppetizerList()
    {
        return DataLists.FoodList
            .Where(f => f.Category == "Appetizer")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            })
            .ToList();
    }

    public static List<SelectListItem> GetSandwichList()
    {
        return DataLists.FoodList
            .Where(f => f.Category == "Sandwich")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            })
            .ToList();
    }

    public static List<SelectListItem> GetDessertList()
    {
        return DataLists.FoodList
            .Where(f => f.Category == "Dessert")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            })
            .ToList();
    }
}