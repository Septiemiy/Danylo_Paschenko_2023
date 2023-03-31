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

int[] numbers = new int[2];

while (true)
{
    Console.WriteLine("Entire initial and final age value: ");
    for (int i = 0; i <= 1; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }
    
    if (numbers[0] < 0)
    {
        Console.WriteLine("\nError: Initial age value is negative\n");
        continue;
    }
    else if (numbers[1] > 100)
    {
        Console.WriteLine("\nError: Final age value is greater than 100\n");
        continue;
    }

    var findAgeBetweenNumbers = from x in people where x.Age >= numbers[0] && x.Age <= numbers[1] select x;
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