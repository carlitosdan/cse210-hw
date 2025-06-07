using System;
using System.Diagnostics.CodeAnalysis;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public bool liveInUsa()
    {
        return _customerAddress.isInUsa();

    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress.GetAddressString();
    }






}