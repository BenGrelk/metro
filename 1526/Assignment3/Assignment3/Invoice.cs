namespace Assignment3;

public class Invoice
{
    private int _quantity;
    private decimal _price;

    public readonly string PartNumber;
    public readonly string PartDescription;

    public int Quantity
    {
        get { return _quantity; }
        set
        {
            if (value > 0)
            {
                _quantity = value;
            }
        }
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value > 0M)
            {
                _price = value;
            }
        }
    }

    public Invoice(string partNumber, string partDescription, int quantity, decimal price)
    {
        PartNumber = partNumber;
        PartDescription = partDescription;
        _price = price;
        _quantity = quantity;
    }

    public float GetInvoiceAmount()
    {
        return (float) (_quantity * _price);
    }

    public override string ToString()
    {
        return string.Format($"{PartNumber,-5} {PartDescription,-20} {Quantity,-5} {Price,6:C}");
    }
}