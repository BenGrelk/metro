namespace Assignment6;

public class TempUtilities
{
    public static decimal Fahrenheit(int celsiusValue)
    {
        decimal celsius = celsiusValue;
        return celsius * 9 / 5 + 32;
    }

    public static decimal Celsius(int fahrenheitValue)
    {
        decimal fahrenheit = fahrenheitValue;
        return (fahrenheit - 32) * 5 / 9;
    }
}