namespace Assignment7;

/// <summary>
///  This class calculates the salary distribution from random sample data.
/// </summary>
public class SalaryDistribution
{
    private readonly int[] _grossSales = new int[100];
    private readonly int[] _grossSalaryRangeCounts = new int[9];

    private readonly string[] _grossSalaryRanges =
    {
        "$200–299",
        "$300–399",
        "$400–499",
        "$500–599",
        "$600–699",
        "$700–799",
        "$800–899",
        "$900–999",
        "$1,000 and over"
    };

    /// <summary>
    ///   Calculate weekly salary.
    /// </summary>
    public void CalculateSalaryDistribution()
    {
        PopulateGrossSales();

        foreach (var grossSale in _grossSales)
        {
            var grossSalary = grossSale * 0.09 + 200;
            switch (grossSalary)
            {
                case >= 200 and < 300:
                    _grossSalaryRangeCounts[0]++;
                    break;
                case >= 300 and < 400:
                    _grossSalaryRangeCounts[1]++;
                    break;
                case >= 400 and < 500:
                    _grossSalaryRangeCounts[2]++;
                    break;
                case >= 500 and < 600:
                    _grossSalaryRangeCounts[3]++;
                    break;
                case >= 600 and < 700:
                    _grossSalaryRangeCounts[4]++;
                    break;
                case >= 700 and < 800:
                    _grossSalaryRangeCounts[5]++;
                    break;
                case >= 800 and < 900:
                    _grossSalaryRangeCounts[6]++;
                    break;
                case >= 900 and < 1000:
                    _grossSalaryRangeCounts[7]++;
                    break;
                case >= 1000:
                    _grossSalaryRangeCounts[8]++;
                    break;
            }
        }

        PrintSalaryDistribution();
    }

    /// <summary>
    ///    Print out salary distribution data to the console output.
    /// </summary>
    private void PrintSalaryDistribution()
    {
        const string title = "Salary Distributions:";
        const string column1 = "Range";
        const string column2 = "Count";

        Console.WriteLine(title);
        Console.WriteLine($"{column1,-15} {column2,-15}");
        for (var i = 0; i < _grossSalaryRanges.Length; i++)
        {
            Console.WriteLine($"{_grossSalaryRanges[i],-15} {_grossSalaryRangeCounts[i],-15}");
        }
    }

    /// <summary>
    ///   Generate some random sales data.
    /// </summary>
    private void PopulateGrossSales()
    {
        //Generate list 100 entries of gross sales between 1,000 and 10,000
        var rand = new Random();
        for (var i = 0; i < _grossSales.Length; i++)
        {
            var randomGrossSales = rand.Next(1000, 10000);
            _grossSales[i] = randomGrossSales;
        }
    }
}