List<string> numbers = new List<string>();
List<int> numberDuplicationIndex= new List<int>();

Console.WriteLine("Entire 10 numbers: ");
for (int i = 0; i < 10; i++)
{
    numbers.Add(Console.ReadLine());
}

Console.WriteLine("\nTo exit the program, entire \"q\"\n");
while (true)
{
    numberDuplicationIndex.Clear();

    string userSymbol = Console.ReadLine();

    if (userSymbol == "q") break;

    if (numbers.Contains(userSymbol))
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == userSymbol) numberDuplicationIndex.Add(i);
        }
    }
    else
    {
        Console.WriteLine("\nList of numbers don`t have such number or entered symbol isn't a number\n");
        continue;
    }

    for (int i = 0; i < numberDuplicationIndex.Count; i++)
    {
        Console.WriteLine("+");
        numbers.Insert(numberDuplicationIndex[i], userSymbol);
    }
    foreach (int i in numberDuplicationIndex) Console.Write($"{i} ");
    Console.Write("Result: ");
    foreach (string i in numbers) Console.Write($"{i} ");
    Console.WriteLine("\n");
}