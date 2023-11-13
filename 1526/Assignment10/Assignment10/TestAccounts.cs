namespace Assignment10;

public class TestAccounts
{
    private List<Account> bankingAccounts = new List<Account>(); // private local class variables

    public void PerformAccountTests()
    {
        // code to create a SavingsAccount class and add it to the bankingAccounts list
        // code to create a CheckingAccount class and add it to the bankingAccounts list
        // code to loop through the list
        // you will need the switch example listed in the Week 10 lecture document to determine class type
        // you will use it to determine the class type and then call the appropriate test method for processing
    }

    private void TestSavingsAccount(SavingsAccount savingsAccount)
    {
        // code to perform tests on the SavingsAccount class
        // code to display the results of each step of the testing; print out the class after each operation
        // need to display the initial account status and then after each action display transaction results
        // Hint: override the ToString() implementation of SavingsAccount
        // need to call the AccountUtilities methods to perform your tests
    }

    private void TestCheckingAccount(CheckingAccount checkingAccount)
    {
        // code to perform tests on the CheckingAccount class
        // code to display the results of each step of the testing; print out the class after each operation
        // need to display the initial account status and then after each action display transaction results
        // Hint: override the ToString() implementation of CheckingAccount
        // need to call the AccountUtilities methods to perform your tests
    }
}