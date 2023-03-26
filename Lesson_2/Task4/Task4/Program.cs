List<Owner> owners = new List<Owner>()
{
    new Owner(1, "Margaret", "Street 1"),
    new Owner(2, "Alex", "Street 2"),
    new Owner(3, "Vadim", "Street 3"),
    new Owner(4, "Tom", "Street 4"),
    new Owner(5, "Andrew", "Street 5"),
    new Owner(6, "Bob", "Street 6"),
    new Owner(7, "Osas", "Street 7"),
    new Owner(8, "Daniil", "Street 8"),
    new Owner(9, "Margaret", "Street 9"),
    new Owner(10, "Syuzi", "Street 10")
};

List<Car> cars = new List<Car>()
{
    new Car(4, 1),
    new Car(7, 2),
    new Car(3, 3),
    new Car(1, 4),
    new Car(9, 5),
    new Car(2, 6),
    new Car(5, 7),
    new Car(10, 8),
    new Car(8, 9),
    new Car(6, 10)
};

while (true)
{
    Console.Write("Entire the car number: ");
    int carNumber = int.Parse(Console.ReadLine());

    if (carNumber > 10)
    {
        Console.WriteLine("\nError: The number of cars is only 10, your number is more than 10\n");
        continue;
    }

    var selectOwnerByCarsNumber = owners.Where(x => cars.Any(y => y.OwnerId == x.Id && y.Number == carNumber));

    Console.WriteLine("\nResult:\n");
    foreach (var i in selectOwnerByCarsNumber) Console.WriteLine($"Name: {i.Name}, Address: {i.Address}");
    break;
}

class Owner
{
    public int Id { get; }
    public string Name { get; }
    public string Address { get; }
    public Owner(int id, string name, string address) =>
        (Id, Name, Address) = (id, name, address);
}

class Car
{
    public int Number { get; }
    public int OwnerId { get; }
    public Car(int number, int ownerId) =>
        (Number, OwnerId) = (number, ownerId);
}