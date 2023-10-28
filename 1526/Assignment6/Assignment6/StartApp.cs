namespace Assignment6;

public class StartApp
{
    private const string FullName = "Benjamin Grelk";
    private const string ClassName = "INFO 1526 C-Sharp Programming I";
    private const string Assignment = "Assignment #6";

    public void Start()
    {
        DisplayAssignmentHeading();
        var convertTemperature = new ConvertTemperature();
        convertTemperature.EnterTemperatureChoice();
    }

    private static void DisplayAssignmentHeading()
    {
        Console.WriteLine(string.Empty);
        Console.WriteLine($"Full Name: {FullName} Class: {ClassName} Assignment: {Assignment}");
        Console.WriteLine($"Date: {DateTime.Now:MMMM d, yyyy}");
        Console.WriteLine(string.Empty);
    }
}