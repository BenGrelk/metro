namespace Assignment4;

public class CalculateCommission
{
    private decimal totalSales = 0;

    private Dictionary<int, decimal> itemCosts = new()
    {
        {1, 5.99m},
        {2, 19.99m},
        {3, 59.99m},
        {4, 99.99m},
        {5, 199.00m}
    };
    
    public void EnterSales()
    {
        var itemNum = 0;
        var itemQuantity = 0;

        while (itemNum != -1 && itemQuantity != -1)
        {
            itemNum = GetItemNum();
            if (itemNum != -1)
            {
                itemQuantity = GetItemQuantity();
            }
            else
            {
                break;
            }
            
            if (itemQuantity != -1)
            {
                CalculateItemSale(itemQuantity, itemCosts[itemNum]);
            }
            else
            {
                break;
            }
        } 
        
        DisplayTotalSales();
    }

    private int GetItemNum()
    {
        int itemNum;
        Console.Write("Enter an item number (1, 2, 3, 4, 5, -1): ");
        while (true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out itemNum))
            {
                if (itemNum == -1 || itemNum >= 1 && itemNum <= 5)
                {
                    break;
                }

                Console.Write("Invalid input. Please enter a number between 1 and 5 or -1 to quit: ");
            }
            else
            {
                Console.Write("Invalid input. Please enter a number between 1 and 5 or -1 to quit: ");
            }
        }

        return itemNum;
    }

    private int GetItemQuantity()
    {
        int itemQuantity;
        
        while (true)
        {
            Console.Write("Enter the quantity sold: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out itemQuantity))
            {
                if (itemQuantity == -1 || itemQuantity > 0)
                {
                    break;
                }

                Console.Write("Invalid input. Please enter a positive number or -1 to quit: ");
            }
            else
            {
                Console.Write("Invalid input. Please enter a positive number or -1 to quit: ");
            }
        }
        return itemQuantity;
    }
    
    private void DisplayTotalSales()
    {
        Console.WriteLine($"Total sales: {totalSales:C} Total earnings: {totalSales * 0.09m + 200:C}");
    }

    private void CalculateItemSale(int itemQuantity, decimal itemCost)
    {
        var itemSale = itemQuantity * itemCost;
        totalSales += itemSale;
    }
}