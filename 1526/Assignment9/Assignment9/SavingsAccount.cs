namespace Assignment9;

public class SavingsAccount
{
    private decimal _savingsBalance;
    private readonly decimal _annualInterestRate;
    
    public decimal SavingsBalance
    {
        get => _savingsBalance;
        set => _savingsBalance = value;
    }
    
    public decimal AnnualInterestRate => _annualInterestRate;
    
    public SavingsAccount(decimal savingsBalance, decimal annualInterestRate)
    {
        _savingsBalance = savingsBalance;
        _annualInterestRate = annualInterestRate;
    }
}