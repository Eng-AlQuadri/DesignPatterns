namespace Builder;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person.Builder()
            .SetFirstName("John")
            .SetLastName("Doe")
            .SetAddress("USA")
            .SetCountry("WH")
            .SetCity("NVD")
            .SetIsEmployeed(false)
            .SetIsHomeOwner(true)
            .Build();

        Console.WriteLine($"{person.FirstName} | {person.LastName} | {person.Address} | {person.Country} | {person.City} | {person.IsEmployeed} | {person.IsHomeOwner}");
    }
}
