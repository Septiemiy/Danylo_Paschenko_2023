Console.Write("Entire first string: ");
string string1 = Console.ReadLine();

Console.Write("Entire second string: ");
string string2 = Console.ReadLine();

if (string1.Length > string2.Length)
{
    Console.WriteLine($"\nResult: {string1} {string2}");
}
else if (string1.Length == string2.Length)
{
    Console.WriteLine(" ");
}
else
{
    try
    {
        string[] splitString = string2.Split(string1[0]);
        Console.WriteLine("\nResult: ");
        foreach (string i in splitString) Console.WriteLine($"{i} ");
    }
    catch
    {
        Console.WriteLine("\nError, can`t split longest string on first symbol shortest string");
    }
}