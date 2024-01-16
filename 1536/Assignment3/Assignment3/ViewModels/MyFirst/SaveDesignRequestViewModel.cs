namespace Assignment3.ViewModels;

public class SaveDesignRequestViewModel
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
}