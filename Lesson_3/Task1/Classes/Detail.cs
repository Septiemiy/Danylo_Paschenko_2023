using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Detail
{
    public float Price { get; set; }
    public string Supplier { get; set; }
    public string Country { get; set; }
    public string Name { get; set; }

    public virtual void GetDetailInformation()
    {
        Console.Write("\nEntire detail price: ");
        Price = float.Parse(Console.ReadLine());

        Console.Write("\nEntire detail supplier: ");
        Supplier = Console.ReadLine();

        Console.Write("\nEntire supplier country: ");
        Country = Console.ReadLine();

        Console.Write("\nEntire detail name: ");
        Name = Console.ReadLine();
    }
}
