using Assignment4WebApp.FoodFunctions;
using Assignment4WebApp.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Assignment4WebApp.ViewModels.Food;
using Assignment4WebApp.Models.View;

namespace Assignment4WebApp.Controllers;

public class FoodController : Controller
{
    public IActionResult Index()
    {
        return View(new IndexViewModel());
    }

    public IActionResult New()
    {
        var model = new OrderNewViewModel
        {
            Order = new Order(),

            BeverageList = FoodViewFunctions.GetBeverageList(),
            AppetizerList = FoodViewFunctions.GetAppetizerList(),
            MainCourseList = FoodViewFunctions.GetSandwichList(),
            DessertList = FoodViewFunctions.GetDessertList()
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult New(OrderNewViewModel model)
    {
        if (ModelState.IsValid)
        {
            var order = model.Order;
            order!.OrderTotal = FoodViewFunctions.GetFoodList()
                .Where(f => f.Item == order.BeverageItem || f.Item == order.AppetizerItem ||
                            f.Item == order.MainCourseItem || f.Item == order.DessertItem)
                .Sum(f => f.ItemCost);
            DataLists.OrderList.Add(new OrderEntity
            {
                OrderId = order.OrderId,
                OrderTotal = order.OrderTotal,
                BeverageItem = order.BeverageItem,
                AppetizerItem = order.AppetizerItem,
                MainCourseItem = order.MainCourseItem,
                DessertItem = order.DessertItem
            });
            return RedirectToAction("Index");
        }
        model.Message = "Please fill in all fields.";
        
        model.BeverageList = FoodViewFunctions.GetBeverageList();
        model.AppetizerList = FoodViewFunctions.GetAppetizerList();
        model.MainCourseList = FoodViewFunctions.GetSandwichList();
        model.DessertList = FoodViewFunctions.GetDessertList();

        return View(model);
    }

    public IActionResult Edit(string id)
    {
        var orderEntity = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
        if (orderEntity == null)
        {
            return RedirectToAction("Index");
        }

        var model = new OrderEditViewModel
        {
            Order = new Order
            {
                OrderId = orderEntity.OrderId,
                OrderTotal = orderEntity.OrderTotal,
                BeverageItem = orderEntity.BeverageItem,
                AppetizerItem = orderEntity.AppetizerItem,
                MainCourseItem = orderEntity.MainCourseItem,
                DessertItem = orderEntity.DessertItem
            },
            BeverageList = FoodViewFunctions.GetBeverageList(),
            AppetizerList = FoodViewFunctions.GetAppetizerList(),
            MainCourseList = FoodViewFunctions.GetSandwichList(),
            DessertList = FoodViewFunctions.GetDessertList()
        };

        return View(model);
    }
    
    [HttpPost]
    public IActionResult Edit(OrderEditViewModel model)
    {
        if (ModelState.IsValid)
        {
            var order = model.Order;
            order!.OrderTotal = FoodViewFunctions.GetFoodList()
                .Where(f => f.Item == order.BeverageItem || f.Item == order.AppetizerItem ||
                            f.Item == order.MainCourseItem || f.Item == order.DessertItem)
                .Sum(f => f.ItemCost);
            var orderEntity = DataLists.OrderList.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (orderEntity == null)
            {
                return RedirectToAction("Index");
            }

            orderEntity.OrderTotal = order.OrderTotal;
            orderEntity.BeverageItem = order.BeverageItem;
            orderEntity.AppetizerItem = order.AppetizerItem;
            orderEntity.MainCourseItem = order.MainCourseItem;
            orderEntity.DessertItem = order.DessertItem;
            return RedirectToAction("Index");
        }
        model.Message = "Please fill in all fields.";
        
        model.BeverageList = FoodViewFunctions.GetBeverageList();
        model.AppetizerList = FoodViewFunctions.GetAppetizerList();
        model.MainCourseList = FoodViewFunctions.GetSandwichList();
        model.DessertList = FoodViewFunctions.GetDessertList();

        return View(model);
    }

    public IActionResult Delete(string id)
    {
        var orderEntity = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
        if (orderEntity == null)
        {
            return RedirectToAction("Index");
        }

        DataLists.OrderList.Remove(orderEntity);
        return RedirectToAction("Index");
    }
}