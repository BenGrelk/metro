namespace Assignment1;

public class BasePlusCommissionEmployee : CommissionEmployee
{
    private readonly decimal _baseWeeklySalary;

    private decimal BaseWeeklySalary
    {
        get => _baseWeeklySalary;
        init
        {
            if (value > 0) _baseWeeklySalary = value;
            else throw new Exception("Weekly salary must be more than 0!");
        }
    }

    public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurity,
        decimal grossWeeklySales,
        decimal commissionRate, decimal baseWeeklySalary) : base(firstName, lastName, socialSecurity, grossWeeklySales,
        commissionRate)
    {
        BaseWeeklySalary = baseWeeklySalary;
    }

    public override decimal GetPaymentAmount()
    {
        return base.GetPaymentAmount() + IncreasedSalary();
    }

    private decimal IncreasedSalary()
    {
        return BaseWeeklySalary + BaseWeeklySalary * 0.1M;
    }

    public override string ToString()
    {
        return $@"Base-Salaried: {this.CommissionsData()}; Base Weekly Salary: ${BaseWeeklySalary}
New base salary with 10% increase is: {IncreasedSalary()}
Payment Due: ${GetPaymentAmount()}";
    }
}