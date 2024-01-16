using Assignment4WebApp.FoodFunctions;
using Assignment4WebApp.Models.Data;

namespace Assignment4WebApp;

public static class DataPrep
{
    public static void LoadFoodEntities()
    {
        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Soda",
            Category = "Beverage",
            ItemCost = 2.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Iced Tea",
            Category = "Beverage",
            ItemCost = 1.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Coffee",
            Category = "Beverage",
            ItemCost = 1.50M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Milk",
            Category = "Beverage",
            ItemCost = 2.50M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Juice",
            Category = "Beverage",
            ItemCost = 2.50M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Mozzarella Sticks",
            Category = "Appetizer",
            ItemCost = 9.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Buffalo Wings",
            Category = "Appetizer",
            ItemCost = 13.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Crab Dip",
            Category = "Appetizer",
            ItemCost = 9.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Chips and Salsa",
            Category = "Appetizer",
            ItemCost = 8.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Hamburger",
            Category = "Sandwich",
            ItemCost = 10.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Cheeseburger",
            Category = "Sandwich",
            ItemCost = 11.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Philly Cheesesteak",
            Category = "Sandwich",
            ItemCost = 10.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Chicken Sandwich",
            Category = "Sandwich",
            ItemCost = 12.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Turkey Club Sandwich",
            Category = "Sandwich",
            ItemCost = 10.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Fudge Sundae",
            Category = "Dessert",
            ItemCost = 8.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Apple Crisp",
            Category = "Dessert",
            ItemCost = 7.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Chocolate Cake",
            Category = "Dessert",
            ItemCost = 9.95M
        });

        DataLists.FoodList.Add(new FoodItemEntity
        {
            Item = "Cheesecake",
            Category = "Dessert",
            ItemCost = 10.95M
        });

        // Add to OrderList
        DataLists.OrderList.Add(new OrderEntity
        {
            OrderId = FoodViewFunctions.GetNewOrderId(),
            OrderTotal = 31.8M,
            BeverageItem = "Soda",
            AppetizerItem = "Mozzarella Sticks",
            MainCourseItem = "Hamburger",
            DessertItem = "Fudge Sundae"
        });

        DataLists.OrderList.Add(new OrderEntity
        {
            OrderId = FoodViewFunctions.GetNewOrderId(),
            OrderTotal = 35.8M,
            BeverageItem = "Iced Tea",
            AppetizerItem = "Buffalo Wings",
            MainCourseItem = "Cheeseburger",
            DessertItem = "Apple Crisp"
        });
    }
}