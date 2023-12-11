namespace Assignment1;

public abstract class Employee : IPayable
{
    private string FirstName { get; }

    private string LastName { get; }

    private string SocialSecurity { get; }

    protected Employee(string firstName, string lastName, string socialSecurity)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurity = socialSecurity;
    }

    public override string ToString()
    {
        return $@"Employee: {FirstName} {LastName}
Social Security Number: {SocialSecurity}";
    }

    public abstract decimal GetPaymentAmount();
}