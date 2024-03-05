using System;

public class InventoryItem
{
    // Properties
    public string Name { get; private set; }
    public int ID { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    // Constructor
    public InventoryItem(string name, int id, double price, int quantity)
    {
        Name = name;
        ID = id;
        Price = price;
        Quantity = quantity;
    }

    // Methods
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"{Name}'s price has been updated to {Price:C}");
    }

    public void RestockItem(int additionalQuantity)
    {
        Quantity += additionalQuantity;
        Console.WriteLine($"Restocked {additionalQuantity} {Name}(s). New quantity: {Quantity}");
    }

    public void SellItem(int quantitySold)
    {
        if (quantitySold <= Quantity)
        {
            Quantity -= quantitySold;
            Console.WriteLine($"Sold {quantitySold} {Name}(s). Remaining quantity: {Quantity}");
        }
        else
        {
            Console.WriteLine($"Insufficient stock. Could not sell {quantitySold} {Name}(s).");
        }
    }

    public bool IsInStock()
    {
        return Quantity > 0;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity: {Quantity}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 1001, 899.99, 10);

        // Testing the methods
        item1.PrintDetails();
        item1.UpdatePrice(999.99);
        item1.RestockItem(5);
        item1.SellItem(3);

        // Checking if the item is in stock
        Console.WriteLine($"Is {item1.Name} in stock? {item1.IsInStock()}");

        // Printing updated details
        item1.PrintDetails();
    }
}
