using System.Runtime.CompilerServices;

List<Persons> person = new List<Persons>()
{
    new Persons("Margaret", 28, "Street 1"),
    new Persons("Vadim", 22, "Street 2"),
    new Persons("Daniil", 33, "Street 3"),
    new Persons("Andrew", 20, "Street 4"),
    new Persons("Vadim", 15, "Street 5"),
    new Persons("Daniil", 21, "Street 6"),
    new Persons("Osas", 53, "Street 7"),
    new Persons("Andrew", 33, "Street 8"),
    new Persons("Margaret", 11, "Street 9"),
    new Persons("Syuzi", 16, "Street 10")
};

while (true)
{
    Console.Write("Entire client name: ");
    string clientsName = Console.ReadLine();

    var selectClients = from x in person where x.Name == clientsName && x.Age > 18 select x;

    if (selectClients.Count() == 0)
    {
        Console.WriteLine("\nError: there is no clients with that name\n");
        continue;
    }

    Console.WriteLine("\nResult:\n");
    foreach (var i in selectClients) Console.WriteLine($"Name: {i.Name}, Age: {i.Age}, Address: {i.Address}");
    break;
}

class Persons
{
    public string Name { get; }
    public int Age { get; }
    public string Address { get; }
    public Persons(string name, int age, string address) =>
        (Name, Age, Address) = (name, age, address);
}