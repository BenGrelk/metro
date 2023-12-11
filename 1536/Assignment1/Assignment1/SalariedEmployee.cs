namespace Assignment1;

public class SalariedEmployee : Employee
{
    private readonly decimal _weeklySalary;

    private decimal WeeklySalary
    {
        get => _weeklySalary;
        init
        {
            if (value > 0) _weeklySalary = value;
            else throw new Exception("Salary must be greater than 0!");
        }
    }

    public SalariedEmployee(string firstName, string lastName, string socialSecurity, decimal weeklySalary) : base(
        firstName, lastName, socialSecurity)
    {
        WeeklySalary = weeklySalary;
    }

    public override decimal GetPaymentAmount()
    {
        return WeeklySalary;
    }

    public override string ToString()
    {
        return $@"Salaried {base.ToString()}
Weekly Salary: ${WeeklySalary:0.00}
Payment Due: ${GetPaymentAmount():0.00}
";
    }
}