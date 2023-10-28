namespace Assignment8;

public class Invoice
{
    private readonly int _quantityValue;
    private readonly decimal _priceValue;
    private int PartNumber { get; }
    public string PartDescription { get; }

    public int Quantity
    {
        get => _quantityValue;

        private init
        {
            if (value > 0)
                _quantityValue = value;
        }
    }

    public decimal Price
    {
        get => _priceValue;
        private init
        {
            if (value >= 0M)
                _priceValue = value;
        }
    }

    public Invoice(int part, string description, int count, decimal pricePerItem)
    {
        PartNumber = part;
        PartDescription = description;
        Quantity = count;
        Price = pricePerItem;
    }


    public override string ToString()
    {
        return $"{PartNumber,-5} {PartDescription,-20} {Quantity,-5} {Price,6:C}";
    }
}