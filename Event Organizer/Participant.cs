using System;

public class Participant
{
    // Private Fields
    private Address address;
    private string firstName;
    private string lastName;

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


    // Constructors
    public Participant()
    {
    }

    public Participant(Participant theOther)
    {
        this.address = new Address(theOther.address);
        this.firstName = theOther.firstName;
        this.lastName = theOther.lastName;
    }

    public Participant(string firstName, string lastName, Address adr)
    {
        this.address = adr;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // Methods
    public override string ToString()
    {
        return $"{FullName}: {address.GetAddressLabel()}";
    }

    public bool Validate()
    {
        // Add validation logic here
        // For simplicity, assuming all fields must be non-null or non-empty
        return address != null && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && address.Validate();
    }
}
