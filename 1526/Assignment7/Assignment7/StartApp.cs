namespace Assignment7;

public class StartApp
{
    private const string FullName = "Benjamin Grelk";
    private const string ClassName = "INFO 1526 C-Sharp Programming I";
    private const string Assignment = "Assignment #7";

    public void Start()
    {
        DisplayAssignmentHeading();

        try
        {
            var salaryDistribution = new SalaryDistribution();
            salaryDistribution.CalculateSalaryDistribution();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void DisplayAssignmentHeading()
    {
        Console.WriteLine(string.Empty);
        Console.WriteLine($"Full Name: {FullName} Class: {ClassName} Assignment: {Assignment}");
        Console.WriteLine($"Date: {DateTime.Now:MMMM d, yyyy}");
        Console.WriteLine(string.Empty);
    }
}