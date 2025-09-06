namespace Builder;

public class Person
{
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? Address { get; private set; }
    public string? City { get; private set; }
    public string? Country { get; private set; }
    public bool IsEmployeed { get; private set; }
    public bool IsHomeOwner { get; private set; }

    private Person() { }

    public class Builder
    {
        private readonly Person _person = new Person();

        public Person Build()
        {
            return _person;
        }

        public Builder SetFirstName(string firstName)
        {
            _person.FirstName = firstName;
            return this;
        }

        public Builder SetLastName(string lastName)
        {
            _person.LastName = lastName;
            return this;
        }

        public Builder SetAddress(string address)
        {
            _person.Address = address;
            return this;
        }

        public Builder SetCity(string city)
        {
            _person.City = city;
            return this;
        }

        public Builder SetCountry(string country)
        {
            _person.Country = country;
            return this;
        }

        public Builder SetIsEmployeed(bool isEmployeed)
        {
            _person.IsEmployeed = isEmployeed;
            return this;
        }

        public Builder SetIsHomeOwner(bool isHomeOwner)
        {
            _person.IsHomeOwner = isHomeOwner;
            return this;
        }
    }
}