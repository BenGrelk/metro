namespace Assignment8;

public static class InvoiceUtilities
{
    public static void SortPartDescription(List<Invoice> invoices)
    {
        var query = from invoice in invoices
            orderby invoice.PartDescription
            select invoice;

        Console.WriteLine("Invoices sorted by description:");
        foreach (var invoice in query) Console.WriteLine(invoice);
    }

    public static void SortByPrice(List<Invoice> invoices)
    {
        var query = from invoice in invoices
            orderby invoice.Price descending
            select invoice;

        Console.WriteLine("Invoices sorted by price:");
        foreach (var invoice in query) Console.WriteLine(invoice);
    }


    public static void SortByQuantitySelectDescriptionQuantity(List<Invoice> invoices) // Part C
    {
        var query = from invoice in invoices
            orderby invoice.Quantity descending
            select new { invoice.PartDescription, invoice.Quantity };

        Console.WriteLine("Invoices sorted by quantity:");
        foreach (var invoice in query) Console.WriteLine($"{invoice.PartDescription,-20} {invoice.Quantity,-5}");
    }

    public static void SortByInvoiceTotalSelectDescriptionInvoiceTotal(List<Invoice> invoices) // Part D
    {
        var query = from invoice in invoices
            orderby invoice.Quantity * invoice.Price descending
            select new { invoice.PartDescription, InvoiceTotal = invoice.Quantity * invoice.Price };

        Console.WriteLine("Invoices sorted by invoice total:");
        foreach (var invoice in query) Console.WriteLine($"{invoice.PartDescription,-20} {invoice.InvoiceTotal,6:C}");
    }

    public static void SortByInvoiceTotalSelectDescriptionInvoiceTotalByRange(List<Invoice> invoices) // Part E
    {
        var query = from invoice in invoices
            let invoiceTotal = invoice.Quantity * invoice.Price
            orderby invoiceTotal descending
            select new { invoice.PartDescription, invoiceTotal };

        Console.WriteLine("Invoices sorted by invoice total in range of 200-500:");
        foreach (var invoice in query.Where(invoice => invoice.invoiceTotal is >= 200 and <= 500))
            Console.WriteLine($"{invoice.PartDescription,-20} {invoice.invoiceTotal,6:C}");
    }
}