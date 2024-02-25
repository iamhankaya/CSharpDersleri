Person[] people = new Person[2]
{
    new Customer()
    {
        Id = 1,
        Name = "mETEHAN",
        Description = "sdadas",
        Address ="dasdas",
        City="sadadad"
    },
    new Student()
    {
        Id = 1,
        Name = "ASDASDA",
        Description = "asdasdsadasd",
        Address="asdasdad",
        StudentId=1
    }
};

foreach (Person person in people)
{
    Console.WriteLine(person.Name);
}
class Person
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public string Description { get; set; }
    public string Address { get; set; }
    

}

class Customer : Person
{
    public string City { get; set; }

}

class Student : Person
{
    public int StudentId { get; set; }
}