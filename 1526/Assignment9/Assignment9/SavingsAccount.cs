namespace Assignment9;

public class SavingsAccount
{
    public decimal SavingsBalance { get; set; }
    public decimal AnnualInterestRate { get; }

    public SavingsAccount(decimal savingsBalance, decimal annualInterestRate)
    {
        SavingsBalance = savingsBalance;
        AnnualInterestRate = annualInterestRate;
    }
}