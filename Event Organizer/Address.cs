using System;

public class Address
{
    // Private Fields
    private string city;
    private Countries country;
    private string street;
    private string zipCode;

    // Properties
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public Countries Country
    {
        get { return country; }
        set { country = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string ZipCode
    {
        get { return zipCode; }
        set { zipCode = value; }
    }

    // Constructors
    public Address():this(string.Empty,string.Empty,string.Empty)
    {

    }

    public Address(Address theOther)
    {
        this.city = theOther.city;
        this.country = theOther.country;
        this.street = theOther.street;
        this.zipCode = theOther.zipCode;
    }

    public Address(string street, string zip, string city) : this(street, zip, city, Countries.Sverige)
    { 

    }
    public Address(string street, string zip, string city, Countries country)
    {
        this.street = street;
        this.zipCode = zip;
        this.city = city;
        this.country = country;
    }

    // Methods
    public string GetAddressLabel()
    {
        return $"{street}, {city}, {zipCode}";
    }

    public string GetCountryString()
    {
        return country.ToString();
    }

    public override string ToString()
    {
        return GetAddressLabel();
    }

    public bool Validate()
    {
        // Add validation logic here
        // For simplicity, assuming all fields must be non-null or non-empty
        return !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(zipCode) && !string.IsNullOrEmpty(city);
    }
}
