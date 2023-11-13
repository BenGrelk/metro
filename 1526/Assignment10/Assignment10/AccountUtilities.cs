namespace Assignment10;

public class AccountUtilities
{
    public static void DebitAccount(Account account, decimal debitAmount)
    {
        // code to perform a debit transaction to withdraw money from the incoming account
        // NOTE: you must determine if you need to cast the Account type to a SavingsAccount or CheckingAccount type
        // Then you can execute the proper Debit method call
        // HINT: use the switch statement that matches class types (week 5)
    }

    public static void CalculateInterest(SavingsAccount savingsAccount)
    {
        // code to calculate the interest payment for the incoming savings account
        // code to then updates the savings account balance with the calculated interest as a credit
    }

    public static void CreditAccount(Account account, decimal creditAmount)
    {
        // code to perform a credit transaction to deposit money to the incoming account
        // NOTE: you must determine if you need to cast the Account type to a SavingsAccount or CheckingAccount type
        // Then you can execute the proper Credit method call
        // HINT: use the switch statement that matches class types (week 5)
    }
}