using Assignment2.Models;

namespace Assignment2.ViewModels;

public class SaveMyFirstRequestViewModel
{
    public Person Person { get; set; }
    
    public bool Football { get; set; }
    public bool Basketball { get; set; }
    public bool Baseball { get; set; }
    public bool Soccer { get; set; }
    
    public string? Message { get; set; }
}