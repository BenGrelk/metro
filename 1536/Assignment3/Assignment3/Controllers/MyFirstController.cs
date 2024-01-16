using Microsoft.AspNetCore.Mvc;
using Assignment3.ViewModels;

namespace Assignment3.Controllers;

public class MyFirstController : Controller
{
    public IActionResult EditDesign()
    {
        // Create a new instance of the view model
        var viewModel = new EditDesignViewModel();

        return View(viewModel);
    }

    public IActionResult SaveDesign(SaveDesignRequestViewModel request)
    {
        Console.WriteLine("SaveDesign called!");

        var response = new SaveDesignResponseViewModel();

        try
        {
            response = new SaveDesignResponseViewModel
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                StreetAddress = request.StreetAddress,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                Baseball = request.Baseball,
                Basketball = request.Basketball,
                Football = request.Football,
                Soccer = request.Soccer,
                Message = "Fake data saved successfully."
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return View(response);
    }
}