public struct Address
{
    public string Street { get; }
    public string City { get; }
    public string ZipCode { get; }

    public Address(string street, string city, string zipCode)
    {
        Street = street;
        City = city;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {ZipCode}";
    }
}
