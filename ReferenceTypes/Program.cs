Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Test";

person2 = person1;

person1.FirstName = "eren";

Console.WriteLine(person1.FirstName);
Console.WriteLine(person2.FirstName);





static void ValueType()
{
	int sayi1 = 10;
	int sayi2 = 20;

	sayi1 = sayi2;
	sayi2 = 100;

	Console.WriteLine(sayi1);
}

static void ArrayReferenceTypes()
{
	int[] sayilar1 = new int[] { 1, 2, 3 };
	int[] sayilar2 = new int[] { 10, 20, 30 };

	sayilar1 = sayilar2;
	sayilar2[0] = 10000;

	foreach (int i in sayilar1)
	{
		Console.WriteLine(i);
	}
	Console.WriteLine("--------------------------------------------------");
	foreach (int i in sayilar2)
	{
		Console.WriteLine(i);
	}
}






class Person
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

class Customer : Person
{
	public string CreditCardNumber { get; set; }

}

class Employee : Person
{
	public int EmployeeNumber { get; set; }

}





