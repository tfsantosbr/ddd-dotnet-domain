namespace Companies.Domain.Base.ValueObjects
{
    public record Address
    {
        public Address(string postalCode, string street, string number, string complement, string district, string city, string state, string country)
        {
            PostalCode = postalCode;
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            Country = country;
        }

        public string PostalCode { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
    }
}
