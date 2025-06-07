using System;

public class Address
{
    private string _streetAddress;
    private string _cityAddress;
    private string _stateProvinceAddress;
    private string _countryAddress;


    public Address(string streetAddress, string cityAddress, string stateProvinceAddress, string countryAddress)
    {
        _streetAddress = streetAddress;
        _cityAddress = cityAddress;
        _stateProvinceAddress = stateProvinceAddress;
        _countryAddress = countryAddress;
    }

    public bool isInUsa()
    {
        return _countryAddress.Trim().ToLower() == "usa";
    }

    public string GetAddressString()
    {
        return $"{_streetAddress}, {_cityAddress}, {_stateProvinceAddress}, {_countryAddress}";
    }

    



}