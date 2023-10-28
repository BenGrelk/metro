namespace Assignment6;

public class ConvertTemperature
{
    public void EnterTemperatureChoice()
    {
        int tempChoice;
        var tempValue = 0;

        do
        {
            tempChoice = GetTemperatureChoice();
            if (tempChoice == -1) continue;
            tempValue = GetTemperatureValue();
            if (tempValue == -1) continue;

            if (tempChoice == 1) ConvertFahrenheitToCelsius(tempValue);
            else ConvertCelsiusToFahrenheit(tempValue);
        } while (tempChoice != -1 && tempValue != -1);
    }

    private static int GetTemperatureChoice()
    {
        int tempChoice;
        do tempChoice = GetInt("Enter temperature choice to convert (1 for Fahrenheit, 2 for Celsius OR -1 to exit): ");
        while (tempChoice != 1 && tempChoice != 2 && tempChoice != -1);

        return tempChoice;
    }

    private static int GetInt(string prompt)
    {
        int value;
        var input = string.Empty;
        do {
            Console.Write(prompt);
            input = Console.ReadLine();
        } while (!int.TryParse(input, out value));
        return value;
    }

    private static int GetTemperatureValue()
    {
        int tempValue;
        do tempValue = GetInt("Enter temperature value to convert (any positive integer OR -1 to exit): ");
        while (tempValue < 0 && tempValue != -1);

        return tempValue;
    }

    private static void ConvertCelsiusToFahrenheit(int celsiusValue)
    {
        var fahrenheitValue = TempUtilities.Fahrenheit(celsiusValue);
        Console.WriteLine($"Celsius: {celsiusValue:F2} Fahrenheit: {fahrenheitValue:F2}");
    }

    private static void ConvertFahrenheitToCelsius(int fahrenheitValue)
    {
        var celsiusValue = TempUtilities.Celsius(fahrenheitValue);
        Console.WriteLine($"Fahrenheit: {fahrenheitValue:F2} Celsius: {celsiusValue:F2}");
    }
}