namespace Assignment1;

public class InvoiceTests
{
    private readonly IPayable[] _invoices = new IPayable[6];

    public InvoiceTests()
    {
        _invoices[0] = new Invoice("01234", "seat", 2, 375M);
        _invoices[1] = new Invoice("56789", "tire", 4, 79.95M);
        _invoices[2] = new SalariedEmployee("John", "Smith", "111-11-1111", 800M);
        _invoices[3] = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M);
        _invoices[4] = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M, .06M);
        _invoices[5] = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000M, .04M, 300M);
    }

    public void RunTests()
    {
        Console.WriteLine("Invoices and Employees Processed Polymorphically");
        Console.WriteLine(string.Empty);
        
        foreach (var invoice in _invoices)
        {
            Console.WriteLine(invoice);
        }
        Console.WriteLine(String.Empty);
        
        Console.WriteLine($"Program ends {DateTime.Now}");
        Console.WriteLine("Press ENTER to continue..");
        Console.ReadLine();
    }
}