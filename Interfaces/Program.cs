using Interfaces;

PersonManager personManager = new PersonManager();
CustomerManager customerManager = new CustomerManager();

customerManager.Add(new SqlServerCustomerDal());

ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}


personManager.Add(new Customer
{
    Id = 1,
    Name = "Metehan",
    Address = "asdada"
}) ;

personManager.Add(new Student
{
    Id=2,Name="Metohanhan",Department="C.Science"
});

interface IPerson
{
    int Id { get; set; }
    string Name { get; set; }   
    
}

class Customer:IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

class Student:IPerson
{
    public string Name { get; set; }
    public int Id { get; set; } 
    public string Department { get; set; }
}


class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.Name);
    }
}
