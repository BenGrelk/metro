namespace Assignment8;

public class TestInvoices
{
    private readonly List<Invoice> _invoices = new();

    public void PerformLinqOperations()
    {
        PopulateInvoiceList();

        InvoiceUtilities.SortPartDescription(_invoices);
        ShowDashes();
        InvoiceUtilities.SortByPrice(_invoices);
        ShowDashes();
        InvoiceUtilities.SortByQuantitySelectDescriptionQuantity(_invoices);
        ShowDashes();
        InvoiceUtilities.SortByInvoiceTotalSelectDescriptionInvoiceTotal(_invoices);
        ShowDashes();
        InvoiceUtilities.SortByInvoiceTotalSelectDescriptionInvoiceTotalByRange(_invoices);
        ShowDashes();

        /* Cool but unconventional way to do this
        // Get each function that sorts the list
        var functions  = from function in typeof(InvoiceUtilities).GetMethods()
            where function.Name.StartsWith("Sort")
            select function;

        foreach (var function in functions)
        {
            // Call the function with the invoice list
            function.Invoke(null, new object[] {_invoices});
            Console.WriteLine(new string('-', 39));
        }
        */
    }

    private static void ShowDashes()
    {
        Console.WriteLine(new string('-', 39));
    }

    private void PopulateInvoiceList()
    {
        // Add invoice objects to the list
        _invoices.Add(new Invoice(101, "Jig Saw", 3, 36.95M));
        _invoices.Add(new Invoice(23, "Ball Peen Hammer", 12, 79.00M));
        _invoices.Add(new Invoice(4, "Box Wrench Set", 9, 29.95M));
        _invoices.Add(new Invoice(145, "Lawn Edger", 25, 139.00M));
        _invoices.Add(new Invoice(310, "Lawn Mower", 5, 399.00M));
        _invoices.Add(new Invoice(45, "Screwdriver Set", 50, 19.95M));
        _invoices.Add(new Invoice(52, "Rachet Set", 35, 99.99M));
        _invoices.Add(new Invoice(10, "Finishing Nails", 100, 2.99M));
        _invoices.Add(new Invoice(220, "Snow Blower", 10, 749.00M));
    }
}