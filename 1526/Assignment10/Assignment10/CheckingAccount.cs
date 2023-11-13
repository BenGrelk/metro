namespace Assignment10;

public class CheckingAccount : Account
{
    private readonly decimal _transactionFee;

    private decimal TransactionFee
    {
        get => _transactionFee;
        init
        {
            if (value < 0)
            {
                throw new Exception("Transaction fee cannot be less than zero");
            }

            _transactionFee = value;
        }
    }

    public CheckingAccount(decimal accountBalance, decimal transactionFee) : base(accountBalance)
    {
        TransactionFee = transactionFee;
    }

    public new void Debit(decimal amount)
    {
        if (!base.Debit(amount)) return;
        AccountBalance -= TransactionFee;
    }

    public override string ToString()
    {
        return $"Account Balance: {AccountBalance:C}\tTransaction Fee: {TransactionFee:C}";
    }
}