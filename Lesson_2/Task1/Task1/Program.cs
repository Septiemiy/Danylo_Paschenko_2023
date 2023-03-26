List<Products> product = new List<Products>()
{
    new Products("Monitor \"Samsung Odyssey G7\"", 20999),
    new Products("PC Case \"Gamdias Argus E2\"", 1499),
    new Products("Processor \"AMD Ryzen 5 5500\"", 3899),
    new Products("Motherboard \"Asus TUF Gaming B550M-Plus\"", 4799),
    new Products("RAM \"Kingston Fury DDR4-3200\"", 1949),
    new Products("Video Card \"Asus PCI-Ex GeForce RTX 3060 Dual OS\"", 16099),
    new Products("SSD \"Kingston SSDNow A400\"", 1229),
    new Products("HDD \"Seagate Basic 1TB\"", 1799),
    new Products("Cooler \"RZTK PcCooler FS-120\"", 129),
    new Products("Power Unit \"Aerocool VX Plus 600\"", 1399)
};

Console.Write("How you want to sort ascending or descending? (Entire a or d, respectively): ");
string userChoice = Console.ReadLine();

if (userChoice == "a")
{
    var sortedByPriceAscending = product.OrderBy(x => x.Price);
    foreach (var x in sortedByPriceAscending) Console.WriteLine($"\n{x.Name}: {x.Price} UAH");
}
else if (userChoice == "d")
{
    var sortedByPriceDescending = product.OrderByDescending(x => x.Price);
    foreach (var x in sortedByPriceDescending) Console.WriteLine($"\n{x.Name}: {x.Price} UAH");
}
else Console.WriteLine("\nInvalid choice");
class Products
{
    public string Name { get; }
    public decimal Price { get; }
    public Products(string name, decimal price) =>
        (Name, Price) = (name, price);
}