using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes;

namespace Task1.Classes
{
    public class RAM : Detail
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public int Frequency { get; set; }

        public override void GetDetailInformation()
        {
            Console.Write("\nEntire RAM type (DDR): ");
            Type = Console.ReadLine();

            Console.Write("\nEntire RAM size (in MB): ");
            Size = int.Parse(Console.ReadLine());

            Console.Write("\nEntire RAM frequency (in MGz): ");
            Frequency = int.Parse(Console.ReadLine());

            base.GetDetailInformation();
        }
    }
}
