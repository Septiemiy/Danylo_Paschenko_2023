using Task1.Classes;

namespace Task1.Classes
{
    public class MotherBoard : Detail
    {
        public string Socket { get; set; }
        public int RAMSlotCount { get; set; }
        public string? DriverInterfaceHDD { get; set; }
        public string? DriverInterfaceSSD { get; set; }

        public override void GetDetailInformation()
        {
            Console.Write("\nEntire mother board socket: ");
            Socket = Console.ReadLine();

            Console.Write("\nEntire mother board RAMs slots count: ");
            RAMSlotCount = int.Parse(Console.ReadLine());

            try
            {
                Console.Write("\nEntire driver interface which mother board support (for HDD, just skip if absent): ");
                DriverInterfaceHDD = Console.ReadLine();
            }
            catch
            {
                DriverInterfaceHDD = null;
            }

            try
            {
                Console.Write("\nEntire driver interface which mother board support (for SSD, just skip if absent): ");
                DriverInterfaceSSD = Console.ReadLine();
            }
            catch
            {
                DriverInterfaceSSD = null;
            }

            base.GetDetailInformation();
        }
    }
}