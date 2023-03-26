List<Person> people = new List<Person>()
{
    new Person("Alex", 28),
    new Person("Vadim", 22),
    new Person("Bob", 33),
    new Person("Andrew", 20),
    new Person("Tom", 15),
    new Person("Daniil", 21),
    new Person("Osas", 53),
    new Person("Jone", 33),
    new Person("Margaret", 11)
};

while (true)
{
    Console.Write("Entire initial age value: ");
    int numberOne = int.Parse(Console.ReadLine());
    if (numberOne < 0)
    {
        Console.WriteLine("\nError: Initial age value is negative\n");
        continue;
    }

    Console.Write("Entire final age value: ");
    int numberTwo = int.Parse(Console.ReadLine());
    if (numberTwo > 100)
    {
        Console.WriteLine("\nError: Final age value is greater than 100\n");
        continue;
    }

    var findAgeBetweenNumbers = from x in people where x.Age >= numberOne && x.Age <= numberTwo select x;
    Console.WriteLine("\nResult:\n");
    foreach (var i in findAgeBetweenNumbers) Console.WriteLine($"{i.Name} {i.Age}");
    break;
}
class Person
{
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age) =>
        (Name, Age) = (name, age);
}