using Task1.Classes;

namespace Task1.Classes
{
    public class Drives : Detail
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public int Speed { get; set; }
        public string Interface { get; set; }
        public int? LifeTime { get; set; }

        public override void GetDetailInformation()
        {
            Console.Write("\nEntire driver type: ");
            Type = Console.ReadLine();

            Console.Write("\nEntire driver size (in GB): ");
            Size = int.Parse(Console.ReadLine());

            Console.Write("\nEntire driver speed (HDD - RPM, SSD - MB/s): ");
            Speed = int.Parse(Console.ReadLine());

            Console.Write("\nEntire driver interface: ");
            Interface = Console.ReadLine();

            Console.Write("\nEntire driver life time (only for SSD, if HDD just skip): ");
            try
            {
                LifeTime = int.Parse(Console.ReadLine());
            }
            catch 
            {
                LifeTime = null;
            }

            base.GetDetailInformation();
        }
    }
}