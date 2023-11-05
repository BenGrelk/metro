namespace Assignment9;

public static class StartApp
{
    private const string FullName = "Benjamin Grelk";
    private const string ClassName = "INFO 1526 C-Sharp Programming I";
    private const string Assignment = "Assignment #9";

    public static void Start()
    {
        DisplayAssignmentHeading();

        try
        {
            var testSavingsAccount = new TestSavingsAccount();
            testSavingsAccount.PerformTestOperations();
        }
        catch (Exception ex) // Required exception handling
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