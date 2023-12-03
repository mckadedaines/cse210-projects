using System.Collections.Generic;
using System.Text;

public class Order
{
    private const decimal ShippingCostUSA = 5m;
    private const decimal ShippingCostInternational = 35m;
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalPrice();
        }

        total += Customer.IsInUSA() ? ShippingCostUSA : ShippingCostInternational;
        return total;
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        foreach (var product in Products)
        {
            sb.AppendLine($"Product: {product.Name}, ID: {product.ProductId}");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Customer: {Customer.Name}\n{Customer.GetAddress()}";
    }
}
