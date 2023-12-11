namespace Assignment1;

public class Invoice : IPayable
{
    private readonly int _quantity;
    private readonly decimal _pricePerItem;

    private string PartNumber { get; }
    private string PartDescription { get; }

    private int Quantity
    {
        get => _quantity;
        init
        {
            if (value > 0) _quantity = value;
            else throw new Exception("Quantity must be more than 0!");
        }
    }

    private decimal PricePerItem
    {
        get => _pricePerItem;
        init
        {
            if (value > 0) _pricePerItem = value;
            else throw new Exception("Price per item must be more than 0!");
        }
    }

    public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
    {
        Quantity = quantity;
        PricePerItem = pricePerItem;
        PartNumber = partNumber;
        PartDescription = partDescription;
    }

    public decimal GetPaymentAmount()
    {
        return Quantity * PricePerItem;
    }

    public override string ToString()
    {
        return $@"Invoice:
Part Number: {PartNumber} ({PartDescription})
Quantity: {Quantity}
Price Per Item: ${PricePerItem:0.00}
Payment Due: ${GetPaymentAmount():0.00}
";
    }
}