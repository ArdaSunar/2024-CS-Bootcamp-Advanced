Customer customer1 = new Customer() { Id = 1 , FirstName= "Arda", LastName = "Sunar", City = "Samsun"};
Customer customer2 = new Customer(2, "Abuzer", "Sunar", "Kırıkkale");

Console.WriteLine(customer1.FirstName);
Console.WriteLine(customer2.FirstName);








class Customer
{
    public Customer()
    {

    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;

    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}