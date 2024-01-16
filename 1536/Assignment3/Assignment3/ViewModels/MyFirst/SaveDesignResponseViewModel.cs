using Microsoft.AspNetCore.Mvc.Rendering;
using Assignment3.Models;

namespace Assignment3.ViewModels;

public class SaveDesignResponseViewModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public string? Gender { get; set; }

    public bool Football { get; set; }
    public bool Baseball { get; set; }
    public bool Basketball { get; set; }
    public bool Soccer { get; set; }

    public string Message { get; set; }

    public List<SelectListItem> Countries { get; } = new()
    {
        new SelectListItem("United States", "US"),
        new SelectListItem("Canada", "CA"),
        new SelectListItem("Mexico", "MX"),
        new SelectListItem("United Kingdom", "UK"),
        new SelectListItem("France", "FR"),
        new SelectListItem("Germany", "DE"),
        new SelectListItem("Italy", "IT"),
        new SelectListItem("Spain", "ES"),
        new SelectListItem("China", "CN"),
        new SelectListItem("Japan", "JP"),
        new SelectListItem("South Korea", "KR"),
    };

    public List<Friend> Friends { get; } = new()
    {
        new Friend { FirstName = "Jim", LastName = "Harrison", City = "Omaha", State = "NE" },
        new Friend { FirstName = "Bob", LastName = "Johnson", City = "Lincoln", State = "NE" },
        new Friend { FirstName = "Doug", LastName = "Jenkins", City = "North PLatte", State = "NE" }
    };

    public List<string> Genders { get; } = new() { "Male", "Female" };
}