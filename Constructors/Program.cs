Customer customer1 = new Customer { Id = 1, Firstname = "Eren", LastName = "Ekinci", City = "İstanbul" };

Customer customer2 = new Customer(2, "Deneme", "Deneme", "Ankara");


Console.WriteLine(customer2.Firstname);



class Customer
{
	public Customer(int id, string firstName, string lastName, string city)
	{
		Id = id;
		Firstname = firstName;
		LastName = lastName;
		City = city;
	}

	public Customer()
	{
		Console.WriteLine("Yapıcı Method çalıştı.");
	}
	public int Id { get; set; }
	public string Firstname { get; set; }
	public string LastName { get; set; }
	public string City { get; set; }
}