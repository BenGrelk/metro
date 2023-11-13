namespace Assignment10;

public class SavingsAccount : Account
{
    private readonly decimal _interestRate;

    public decimal InterestRate
    {
        get => _interestRate;
        private init
        {
            if (value < 0)
            {
                throw new Exception("Interest rate cannot be less than zero");
            }

            _interestRate = value;
        }
    }

    public SavingsAccount(decimal accountBalance, decimal interestRate) : base(accountBalance)
    {
        InterestRate = interestRate;
    }

    public override string ToString()
    {
        return $"Account Balance: {AccountBalance:C}\tInterest Rate: {InterestRate:P}";
    }
}