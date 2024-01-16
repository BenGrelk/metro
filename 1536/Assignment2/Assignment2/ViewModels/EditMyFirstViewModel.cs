using Assignment2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment2.ViewModels;

public class EditMyFirstViewModel
{
    public Person Person { get; set; }

    public string? Message { get; set; }

    public bool Football { get; set; }
    public bool Basketball { get; set; }
    public bool Baseball { get; set; }
    public bool Soccer { get; set; }

    public List<SelectListItem> Countries { get; }
    public List<string> Genders { get; set; }

    public EditMyFirstViewModel()
    {
        var person = new Person();

        Message = string.Empty;

        Genders = new List<string> { "Male", "Female" };
        Countries = new List<SelectListItem>
        {
            new("United States", "US"),
            new("Canada", "CA"),
            new("United Kingdom", "UK"),
            new("France", "FR"),
            new("Germany", "DE"),
            new("Russia", "RU"),
            new("Japan", "JP"),
            new("China", "CN"),
            new("India", "IN"),
            new("Australia", "AU"),
            new("Brazil", "BR"),
            new("South Africa", "ZA"),
        };
    }
}