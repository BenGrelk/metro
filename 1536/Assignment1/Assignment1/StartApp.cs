namespace Assignment1;

public static class StartApp
{
    private const string FullName = "Benjamin Grelk";
    private const string ClassName = "INFO 1536 C-Sharp Programming II";
    private const string Assignment = "Assignment #1";

    public static void Start()
    {
        DisplayAssignmentHeading();

        try
        {
            var tests = new InvoiceTests();
            tests.RunTests();
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