using System;
using System.Reflection.Emit;

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

    public double GetTotalPrice()
    {
        double totalP = 0;
        foreach (var prod in _products)
        {
            totalP = totalP + prod.productTotalCost();

        }
        return totalP;
    }

    public double GetShippingCost()
    {
        if (_customer.liveInUsa())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    public string GetPackingLabel()
    {
        string myLabel = "\nPacking Label:\n";
        foreach (var prod in _products)
        {
            myLabel = myLabel + $"{prod.GetProductId()} - {prod.GetProductName()}\n";
        }
        return myLabel;
    }

    public string GetShippingLabel()
    {
        string shipingLabel = "\nShipping Label:\n";
        shipingLabel += _customer.GetCustomerName() + "\n";
        shipingLabel += _customer.GetCustomerAddress();

        return shipingLabel;


    }

    public double getTotalCost()
    {

        double total = 0;
        foreach (var p in _products)
        {
            total += p.productTotalCost();
        }
        total += GetShippingCost();
        return total;
    }






}