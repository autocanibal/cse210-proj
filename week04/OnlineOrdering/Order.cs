using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetOrderTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        return total;
    }
    public int shippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public void GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        Console.WriteLine(packingLabel);
    }
    public void GetShippingLabel()
    {
       
        Console.WriteLine("Shipping Label:\n" + _customer.GetName() + "\n" + _customer.GetAddress());
    }
}
