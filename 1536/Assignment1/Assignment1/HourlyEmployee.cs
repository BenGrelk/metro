namespace Assignment1;

public class HourlyEmployee : Employee
{
    private readonly decimal _hourlyWage;
    private readonly decimal _hoursWorked;

    private decimal Wage
    {
        get => _hourlyWage;
        init
        {
            if (value > 0) _hourlyWage = value;
            else throw new Exception("Hours cannot be less than 0!");
        }
    }

    private decimal Hours
    {
        get => _hoursWorked;
        init
        {
            if (value is > 0 and < 168) _hoursWorked = value;
            else throw new Exception("Hours worked must be between 0 and 168!");
        }
    }

    public HourlyEmployee(string firstName, string lastName, string socialSecurity, decimal hourlyWage,
        decimal hoursWorked) : base(firstName, lastName, socialSecurity)
    {
        Wage = hourlyWage;
        Hours = hoursWorked;
    }

    public override string ToString()
    {
        return $@"Hourly {base.ToString()}
Hourly Wage: ${_hourlyWage:0.00}; Hours Worked: {Hours:.00}
Payment Due: ${GetPaymentAmount()}
";
    }

    public override decimal GetPaymentAmount()
    {
        return Hours * Wage;
    }
}