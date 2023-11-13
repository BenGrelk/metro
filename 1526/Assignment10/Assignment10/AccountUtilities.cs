namespace Assignment10;

public abstract class AccountUtilities
{
    public static void DebitAccount(Account account, decimal debitAmount)
    {
        switch (account)
        {
            case SavingsAccount savingsAccount:
                savingsAccount.Debit(debitAmount);
                break;
            case CheckingAccount checkingAccount:
                checkingAccount.Debit(debitAmount);
                break;
        }
    }

    public static void CalculateInterest(SavingsAccount savingsAccount)
    {
        var interest = savingsAccount.AccountBalance * savingsAccount.InterestRate;
        savingsAccount.Credit(interest);
    }

    public static void CreditAccount(Account account, decimal creditAmount)
    {
        switch (account)
        {
            case SavingsAccount savingsAccount:
                savingsAccount.Credit(creditAmount);
                break;
            case CheckingAccount checkingAccount:
                checkingAccount.Credit(creditAmount);
                break;
        }
    }
}