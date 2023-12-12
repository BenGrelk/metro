namespace Assignment1;

public class CommissionEmployee : Employee
{
    private decimal _grossWeeklySales;
    private decimal _commissionRate;

    private decimal GrossWeeklySales
    {
        get => _grossWeeklySales;
        set
        {
            if (value > 0) _grossWeeklySales = value;
            else throw new Exception("Sales must be more than 0!");
        }
    }

    private decimal CommissionRate
    {
        get => _commissionRate;
        set
        {
            if (value is < 1 and > 0) _commissionRate = value;
            else throw new Exception("Commission rate must be between 0 and 1!");
        }
    }

    public CommissionEmployee(string firstName, string lastName, string socialSecurity, decimal grossWeeklySales,
        decimal commissionRate) : base(firstName, lastName, socialSecurity)
    {
        GrossWeeklySales = grossWeeklySales;
        CommissionRate = commissionRate;
    }

    public override decimal GetPaymentAmount()
    {
        return CommissionRate * GrossWeeklySales;
    }

    protected string CommissionsData()
    {
        return $@"Commissions {base.ToString()}
Gross Sales: ${GrossWeeklySales:0,000.00}; Commission Rate: {CommissionRate:0.00}";
    }

    public override string ToString()
    {
        return $@"{CommissionsData()}
Payment Due: ${GetPaymentAmount():0.00}
";
    }
}