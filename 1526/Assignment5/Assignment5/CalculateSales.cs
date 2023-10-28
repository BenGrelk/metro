namespace Assignment5;

public class CalculateSales
{
    private decimal totalSalesProduct1;
    private decimal totalSalesProduct2;
    private decimal totalSalesProduct3;
    private decimal totalSalesProduct4;
    private decimal totalSalesProduct5;

    public void EnterSales()
    {
        int productNum, productQuantity = 0;
        do
        {
            productNum = GetProductNum();
            if (productNum == -1) continue;
            
            productQuantity = GetProductQuantity();
            if (productQuantity == -1) continue;
            
            AddToTotalSales(productNum, productQuantity);
        } while (productNum != -1 && productQuantity != -1);

        PrintSalesTotals();
    }

    private static int GetProductNum()
    {
        int productNum;
        var validInputs = new[] { 1, 2, 3, 4, 5, -1 };

        do productNum = GetInt("Please enter a valid item number: 1, 2, 3, 4, 5 or -1 to quit: ");
        while (!validInputs.Contains(productNum));

        return productNum;
    }

    private static int GetProductQuantity()
    {
        int productQuantity;

        do productQuantity = GetInt("Enter a positive quantity sold or -1: ");
        while (productQuantity <= 0 && productQuantity != -1);

        return productQuantity;
    }
    
    private void AddToTotalSales(int productNum, int productQuantity)
    {
        switch (productNum)
        {
            case 1:
                totalSalesProduct1 += productQuantity * 5.99m;
                break;
            case 2:
                totalSalesProduct2 += productQuantity * 19.99m;
                break;
            case 3:
                totalSalesProduct3 += productQuantity * 59.99m;
                break;
            case 4:
                totalSalesProduct4 += productQuantity * 99.99m;
                break;
            case 5:
                totalSalesProduct5 += productQuantity * 199.00m;
                break;
        }
    }

    private void PrintSalesTotals()
    {
        const string column1 = "Product Number";
        const string column2 = "Total product sales";
        
        Console.WriteLine($"{column1, -20} {column2, 20}");
        Console.WriteLine($"{1, -20} {totalSalesProduct1, 20:C}");
        Console.WriteLine($"{2, -20} {totalSalesProduct2, 20:C}");
        Console.WriteLine($"{3, -20} {totalSalesProduct3, 20:C}");
        Console.WriteLine($"{4, -20} {totalSalesProduct4, 20:C}");
        Console.WriteLine($"{5, -20} {totalSalesProduct5, 20:C}");
    }

    private static int GetInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();
            if (input == null) continue;

            int inputAsInt;
            try
            {
                inputAsInt = int.Parse(input);
            }
            catch
            {
                continue;
            }

            return inputAsInt;
        }
    }
}