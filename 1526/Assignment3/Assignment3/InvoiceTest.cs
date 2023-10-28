using System.Net.Mail;

namespace Assignment3;

public class InvoiceTest
{
    private Invoice invoice;
    private decimal newPrice = 2.00M;
    private int newQuantity = 25;
    
    public InvoiceTest()
    {
        invoice = new Invoice("PartNum-123", "Test invoice 1", newQuantity, newPrice);
    }
    
    public void TestSomeInvoices() // This will be called by the StartApp.cs
    {
        PrintInvoice();
        
        newPrice = -2.00M;
        TestPrice();
        
        newPrice = 4.00M; 
        TestPrice();
        
        newQuantity = -25;
        TestQuantity();

        newQuantity = 50;
        TestQuantity();
    }

    private void TestQuantity()
    {
        invoice.Quantity = newQuantity;
        Console.WriteLine($"Set quantity to {newQuantity}");
        PrintInvoice();
    }
    
    private void TestPrice()
    {
        invoice.Price = newPrice;
        Console.WriteLine($"Set price to {newPrice}");
        PrintInvoice();
    }

    private void PrintInvoice()
    {
        var amount = invoice.GetInvoiceAmount();
        Console.WriteLine($"Invoice amount: {amount}");
        Console.WriteLine(invoice);
        Console.WriteLine();
    }
}