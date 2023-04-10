using Task1.Classes;

namespace Task1.Classes
{
    public class CPU : Detail
    {
        public string Socket { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public float Frequency { get; set; }

        public override void GetDetailInformation()
        {
            Console.Write("\nEntire CPU socket: ");
            Socket = Console.ReadLine();

            Console.Write("\nEntire count of CPU cores: ");
            Cores = int.Parse(Console.ReadLine());

            Console.Write("\nEntire count of CPU threads: ");
            Threads = int.Parse(Console.ReadLine());

            Console.Write("\nEntire CPU frequence (through comma in GHz): ");
            Frequency = float.Parse(Console.ReadLine());

            base.GetDetailInformation();
        }
    }
}
