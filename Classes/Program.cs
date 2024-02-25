using Classes;

CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();
/*
class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Added");
    }
}
*/

Customer customer = new Customer();
customer.Name = "Metehan Kaya";
customer.City = "İzmir";
customer.Address = "asdsad";
customer.Id = 1;

Customer customer2 = new Customer
{
    Id = 2, City = "Ankara", Name = "Metohanhan", Address = "asdasd"

};

