namespace Assignment10;

public class TestAccounts
{
    private readonly List<Account> _bankingAccounts = new();

    public void PerformAccountTests()
    {
        _bankingAccounts.Add(new SavingsAccount(500, 0.05m));
        _bankingAccounts.Add(new CheckingAccount(200, 5m));
        
        foreach (var account in _bankingAccounts)
        {
            switch (account)
            {
                case SavingsAccount savingsAccount1:
                    TestSavingsAccount(savingsAccount1);
                    break;
                case CheckingAccount checkingAccount1:
                    TestCheckingAccount(checkingAccount1);
                    break;
            }

            Console.WriteLine();
        }
    }

    private void TestSavingsAccount(SavingsAccount savingsAccount)
    {
        Console.WriteLine($"Initial value of savings account => {savingsAccount}");
        Console.WriteLine();

        const decimal creditAmount = 500;
        Console.WriteLine($"Credit savings account: {creditAmount:C}");
        AccountUtilities.CreditAccount(savingsAccount, creditAmount);
        Console.WriteLine($"Savings account status => {savingsAccount}");
        Console.WriteLine();
        
        Console.WriteLine("Apply interest savings account balance.");
        AccountUtilities.CalculateInterest(savingsAccount);
        Console.WriteLine($"Savings account status => {savingsAccount}");
        Console.WriteLine();

        const decimal debitAmount = 100;
        Console.WriteLine($"Debit savings account: {debitAmount:C}");
        AccountUtilities.DebitAccount(savingsAccount, debitAmount);
        Console.WriteLine($"Final savings account status => {savingsAccount}");

    }

    private void TestCheckingAccount(CheckingAccount checkingAccount)
    {
        Console.WriteLine($"Initial value of checking account => {checkingAccount}");
        Console.WriteLine();

        const decimal creditAmount = 550;
        Console.WriteLine($"Credit checking account: {creditAmount:C}");
        AccountUtilities.CreditAccount(checkingAccount, creditAmount);
        Console.WriteLine($"Checking account status => {checkingAccount}");
        Console.WriteLine();

        var debitAmount = 1000;
        Console.WriteLine($"Debit checking account: {debitAmount:C}");
        AccountUtilities.DebitAccount(checkingAccount, debitAmount);
        Console.WriteLine($"Checking account status => {checkingAccount}");
        Console.WriteLine();

        debitAmount = 200;
        Console.WriteLine($"Debit checking account: {debitAmount:C}");
        AccountUtilities.DebitAccount(checkingAccount, debitAmount);
        Console.WriteLine($"Final checking account status => {checkingAccount}");
    }
}