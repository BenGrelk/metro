namespace Assignment10;

public class Account
{
    private decimal _accountBalance;

    public decimal AccountBalance
    {
        get => _accountBalance;
        protected set
        {
            if (value < 0)
            {
                throw new Exception("Account balance cannot be less than zero");
            }

            _accountBalance = value;
        }
    }

    protected Account(decimal accountBalance)
    {
        AccountBalance = accountBalance;
    }

    public void Credit(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Credit amount cannot be less than zero");
        }

        AccountBalance += amount;
    }

    public bool Debit(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Debit amount cannot be less than zero");
        }

        if (amount > AccountBalance)
        {
            Console.WriteLine("Debit amount exceeded available balance");
            return false;
        }

        AccountBalance -= amount;
        return true;
    }

    public override string ToString()
    {
        return $"Account Balance: {AccountBalance:C}";
    }
}