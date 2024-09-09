using System;

public class Participant
{
    // Private Fields
    private Address address;
    private string firstName = string.Empty;
    private string lastName = string.Empty;

    #region PROPERTIES
    // Properties
    public Address Address
    {
        get { return address; }
        set { address = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FullName => $"{firstName} {lastName}";
    #endregion
    #region CONTRUCTOR
    // Constructors
    public Participant()
    {
        address = new Address();
    }

    public Participant(string firstName, string lastName, Address adr)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        if(adr != null)
        {
            address = adr;
        }
        else
        {
            address = new Address();
        }
    }
    public Participant(Participant theOther) 
    {
        this.firstName=theOther.FirstName;
        this.lastName=theOther.LastName;
        this.address = new Address(theOther.Address);
    }
    #endregion
    // Methods
    public override string ToString()
    {
        string strOut = string.Format("{0, -21} {1}", FullName, address.ToString());
        return strOut;
    }

    public bool Validate()
    {
        bool addrOk = address.Validate();
        bool namesOk = !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName);
        return addrOk && namesOk;
    }
}
