public class Product
{
    public string Name { get; private set; }
    public int ProductId { get; private set; }
    private decimal Price { get; set; }
    private int Quantity { get; set; }

    public Product(string name, int productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return Price * Quantity;
    }
}
