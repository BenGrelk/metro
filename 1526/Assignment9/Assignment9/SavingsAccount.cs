namespace Assignment9;

public class SavingsAccount
{
    /*
     * Private class variable called savingsBalance
       Private readonly class variable called annualInterestRate
       Public property called SavingsBalance that gets and sets a private class variable
       Public read only property called AnnualInterestRate gets a private variable
     */
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