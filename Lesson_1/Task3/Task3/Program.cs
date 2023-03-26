List<string> numbers = new List<string>();

Console.WriteLine("Entire 10 numbers: ");
for (int i = 0; i < 10; i++)
{
    numbers.Add(Console.ReadLine());
}

Console.Write("Entire number to dublicate: ");
string userSymbol = Console.ReadLine();

if (numbers.Contains(userSymbol))
{
    numbers.Insert(numbers.IndexOf(userSymbol, 0), userSymbol);
}
else
{
    Console.WriteLine("\nList of numbers don`t have such number or entered symbol isn't a number\n");
}

Console.Write("Result: ");
foreach (string i in numbers) Console.Write($"{i} ");