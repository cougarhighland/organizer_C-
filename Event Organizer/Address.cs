using System;

public class Address
{
    // Private Fields
    private string city;
    private Countries country;
    private string street;
    private string zipCode;
    #region PROPERTIES
    // Properties
    public string City
    {
        get { return city; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                city = value;
            }
        }
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
    #endregion
    #region CONSTRUCTOR 
    // Constructors
    public Address(string street, string zip, string city, Countries country)
    {
        this.Street = street;
        this.ZipCode = zip;
        this.City = city;
        this.Country = country;
    }

    public Address(string street, string zip, string city) : this(street, zip, city, Countries.Sverige)
    {
    }

    public Address() : this(string.Empty, string.Empty, string.Empty, Countries.Sverige)
    {
    }

    public Address(Address theOther)
    {
        this.street = theOther.street;
        this.zipCode = theOther.zipCode;
        this.City = theOther.City;
        this.Country = theOther.Country;
    }

    #endregion

    // Methods
    public string GetAddressLabel()
    {
        string strOut = street + Environment.NewLine;
        strOut += zipCode + " " + city;
        return strOut;
    }

    public string GetCountryString()
    {
        string strCountry = country.ToString();
        strCountry = strCountry.Replace("_", " ");
        return strCountry;
    }

    public override string ToString()
    {
        string strOut = string.Format("{0, -25} {1, -8} {2, -1} {3}", street, zipCode, city, GetCountryString());
        return strOut;
    }

    public bool Validate()
    {
        return !string.IsNullOrEmpty(city);
    }
}
