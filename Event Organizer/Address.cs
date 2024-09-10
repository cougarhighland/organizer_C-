using System;
/// <summary>
/// the class that handles address
/// </summary>
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
    /// <summary>
    /// Initializes a new instance of the Address class with specified street, zip code, city, and country
    /// </summary>
    /// <param name="street"></param>
    /// <param name="zip"></param>
    /// <param name="city"></param>
    /// <param name="country"></param>
    public Address(string street, string zip, string city, Countries country)
    {
        this.Street = street;
        this.ZipCode = zip;
        this.City = city;
        this.Country = country;
    }

    /// <summary>
    /// contructor chaining, call the next contructor for resuse
    /// </summary>
    /// <param name="street"></param>
    /// <param name="zip"></param>
    /// <param name="city"></param>
    public Address(string street, string zip, string city) : this(street, zip, city, Countries.Sverige)
    {
    }

    /// <summary>
    /// contructor chaining, call the next contructor for resuse
    /// </summary>
    public Address() : this(string.Empty, string.Empty, string.Empty, Countries.Sverige)
    {
    }
    /// <summary>
    /// /// Initializes a new instance of the Address class by copying the values from another Address instance.
    /// </summary>
    /// <param name="theOther"></param>
    public Address(Address theOther)
    {
        this.street = theOther.street;
        this.zipCode = theOther.zipCode;
        this.City = theOther.City;
        this.Country = theOther.Country;
    }

    #endregion
    #region ANOTHER_METHODS
    // Methods
    /// <summary>
    /// Gets the address label, formatted with street and city information.
    /// </summary>
    /// <returns>A string containing the street, zip code, and city, separated by a newline.</returns>
    public string GetAddressLabel()
    {
        string strOut = street + Environment.NewLine;
        strOut += zipCode + " " + city;
        return strOut;
    }

    /// <summary>
    /// Converts the country enum to a string with underscores replaced by spaces.
    /// </summary>
    /// <returns>A string representation of the country with spaces instead of underscores.</returns>
    public string GetCountryString()
    {
        string strCountry = country.ToString();
        strCountry = strCountry.Replace("_", " ");
        return strCountry;
    }

    /// <summary>
    /// Overrides the ToString method to return a formatted address with country information.
    /// </summary>
    /// <returns>A formatted string containing street, zip code, city, and country.</returns>
    public override string ToString()
    {
        string strOut = string.Format("{0, -25} {1, -8} {2, -1} {3}", street, zipCode, city, GetCountryString());
        return strOut;
    }

    /// <summary>
    /// Validates if the city is not null or empty.
    /// </summary>
    /// <returns>True if the city is valid, otherwise false.</returns>
    public bool Validate()
    {
        return !string.IsNullOrEmpty(city);
    }
    #endregion
}
