namespace Assignment9;

public class TestSavingsAccount
{
    private readonly List<SavingsAccount> _savingsAccounts = new();

    public void PerformTestOperations()
    {
        PopulateSavingsAccountList();

        for (var i = 0; i < 3; i++)
        {
            foreach (var account in _savingsAccounts)
            {
                Console.WriteLine(new string('-', 40));
                PrintSavingsAccounts(account, i);
                CalculateMonthlyInterests(account);
            }
        }
    }

    private void CalculateMonthlyInterests(SavingsAccount account)
    {
        var monthlyInterest = account.CalculateMonthlyInterest();
        account.SavingsBalance += monthlyInterest;
    }

    private void PrintSavingsAccounts(SavingsAccount account, int monthNumber)
    {
        Console.WriteLine($"Current balance after month {monthNumber}: {account.SavingsBalance:C}");
    }

    private void PopulateSavingsAccountList()
    {
        _savingsAccounts.Add(new SavingsAccount(2000, 4));
        _savingsAccounts.Add(new SavingsAccount(3000, 5));
    }
}