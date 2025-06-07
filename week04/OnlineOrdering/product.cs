using System;
using System.Numerics;

public class Product
{
    private int _productId;
    private string _productName;
    private double _productPrice;
    private int _productQuantity;

    public Product(int productId, string productName, double productPrice, int productQuantity)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public double productTotalCost()
    {
        double totalProduct;
        totalProduct = _productPrice * _productQuantity;
        return totalProduct;

    }

    public int GetProductId()
    {
        return _productId;
    }
    public string GetProductName()
    {
        return _productName;
    }



}