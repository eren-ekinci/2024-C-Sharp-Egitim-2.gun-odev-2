
ProjectManager projectManager = new ProjectManager();

projectManager.Add(new InternManager());





interface IPersonManager
{
	void Add();
}

class CustomerManager : IPersonManager
{
	public void Add()
	{
		Console.WriteLine("Müşteri Eklendi.");
	}

}

class EmployeeManager : IPersonManager
{
	public void Add()
	{
		Console.WriteLine("Personel Eklendi.");
	}
}

class ProjectManager
{
	public void Add(IPersonManager personManager)
	{
		personManager.Add();
	}
}

class InternManager : IPersonManager
{
	public void Add()
	{
		Console.WriteLine("Stajyer Eklendi.");
	}
}