using System;

// Create products
Product product1 = new();
product1.Code = "P01";
product1.Name = "Notebook";
product1.Price = 12000;
product1.Quantity = 10;

Product product2 = new();
product2.Code = "P02";
product2.Name = "Pen";
product2.Price = 3000;
product2.Quantity = 20;

Product product3 = new();
product3.Code = "P03";
product3.Name = "Bag";
product3.Price = 85000;
product3.Quantity = 2;

// Create warehouse
Warehouse warehouse1 = new();

// Add products
Console.WriteLine(warehouse1.AddProduct(product1));
Console.WriteLine(warehouse1.AddProduct(product2));
Console.WriteLine(warehouse1.AddProduct(product3));

// Try selling products
Console.WriteLine(warehouse1.TrySellProduct("P01", 3));
Console.WriteLine(warehouse1.TrySellProduct("P03", 3));
Console.WriteLine(warehouse1.TrySellProduct("P99", 1));

// Calculate total stock value
Console.WriteLine("Total stock value: " +
    warehouse1.GetTotalStockValue());

// Print low stock
Console.WriteLine("Low stock products:");
warehouse1.PrintLowStock(2);

// Create second warehouse
Warehouse warehouse2 = new();

Console.WriteLine("Second warehouse value: " +
    warehouse2.GetTotalStockValue());

public class Product
{
    public string Code = "";
    public string Name = "";
    public int Price;
    public int Quantity;

    public bool TrySell(int amount)
    {
        if (amount > 0 && Quantity >= amount)
        {
            Quantity -= amount;
            return true;
        }

        return false;
    }

    public int GetStockValue()
    {
        return Price * Quantity;
    }
}

public class Warehouse
{
    public Product[] Products = new Product[5];
    public int Count = 0;

    public bool AddProduct(Product product)
    {
        if (Count >= 5)
        {
            return false;
        }

        for (int i = 0; i < Count; i++)
        {
            if (Products[i].Code == product.Code)
            {
                return false;
            }
        }

        Products[Count] = product;
        Count++;

        return true;
    }

    public bool TrySellProduct(string code, int amount)
    {
        for (int i = 0; i < Count; i++)
        {
            if (Products[i].Code == code)
            {
                return Products[i].TrySell(amount);
            }
        }

        return false;
    }

    public int GetTotalStockValue()
    {
        int totalValue = 0;

        for (int i = 0; i < Count; i++)
        {
            totalValue += Products[i].GetStockValue();
        }

        return totalValue;
    }

    public void PrintLowStock(int threshold)
    {
        for (int i = 0; i < Count; i++)
        {
            if (Products[i].Quantity <= threshold)
            {
                Console.WriteLine(
                    Products[i].Code + " " +
                    Products[i].Name + " " +
                    Products[i].Quantity
                );
            }
        }
    }
}
