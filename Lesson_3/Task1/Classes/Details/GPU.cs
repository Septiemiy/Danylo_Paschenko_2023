using Task1.Classes;

namespace Task1.Classes
{
    public class GPU : Detail
    {
        public string Type { get; set; }
        public int MemorySize { get; set; }
        public int MemoryInterface { get; set; }
        public int CoreClockSpeed { get; set; }

        public override void GetDetailInformation()
        {
            Console.Write("\nEntire GPU type (Integrated or dedicated): ");
            Type = Console.ReadLine();

            try
            {
                Console.Write("\nEntire GPU memory size in GB (skip if integrated): ");
                MemorySize = int.Parse(Console.ReadLine());
            }
            catch
            {
                MemorySize = 0;
            }

            Console.Write("\nEntire GPU memory interface (bit-width): ");
            MemoryInterface = int.Parse(Console.ReadLine());

            Console.Write("\nEntire GPU core clock speed (in MGz): ");
            CoreClockSpeed = int.Parse(Console.ReadLine());

            base.GetDetailInformation();
        }
    }
}