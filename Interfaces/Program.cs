using System;

IPersonManager customer1 = new CustomerManager();
IPersonManager employee1 = new EmployeeManager();


ProjectManager projectManager = new ProjectManager();
projectManager.Add(customer1);
projectManager.Add(employee1);








interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();
}

 

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Employee Added");
    }

    public void Update()
    {
        Console.WriteLine("Employee Updated");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}