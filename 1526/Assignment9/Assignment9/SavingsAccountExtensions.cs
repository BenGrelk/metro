namespace Assignment9;

public static class SavingsAccountExtensions
{
    public static decimal CalculateMonthlyInterest(this SavingsAccount savingsAccount)
    {
        return savingsAccount.SavingsBalance * savingsAccount.AnnualInterestRate / 12 * 0.01m;
    }
}