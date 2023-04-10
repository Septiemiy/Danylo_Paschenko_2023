using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task1.Classes
{
    public class Computer
    {
        List<RAM> ram = new List<RAM>();
        List<Drives> drives = new List<Drives>();

        public RAM RAM { get; set; }
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public MotherBoard MotherBoard { get; set; }
        public Drives Drives { get; set; }

        public void GetRAM()
        {
            RAM = new RAM();
            RAM.GetDetailInformation();
            ram.Add(RAM);
        }

        public void GetCPU()
        {
            CPU = new CPU();
            CPU.GetDetailInformation();
        }

        public void GetGPU()
        {
            GPU = new GPU();
            GPU.GetDetailInformation();
        }

        public void GetMotherBoard()
        {
            MotherBoard = new MotherBoard();
            MotherBoard.GetDetailInformation();
        }

        public void GetDrives()
        {
            Drives = new Drives();
            Drives.GetDetailInformation();
            drives.Add(Drives);
        }

        public void addToPC(string userChoice)
        {
            switch(userChoice)
            {
                case "1":
                    GetRAM(); break;
                case "2": 
                    GetCPU(); break;
                case "3": 
                    GetGPU(); break;
                case "4": 
                    GetMotherBoard(); break;
                case "5":
                    GetDrives(); break;
                case "6": 
                    detailAudit(); break;
                default:
                    Console.WriteLine("InvalidChoice"); break;
            }
        }

        public void detailAudit()
        {
            cpuAudit();
            ramAudit();
            drivesAudit();
            outputDetailInfo();
        }

        public void cpuAudit()
        {
            if(CPU.Socket != MotherBoard.Socket)
            {
                Console.WriteLine("\nERROR: CPU socket and motherboard socket do not match");
                errorHandler("CPU");
            }
        }

        public void ramAudit()
        {
            if(MotherBoard.RAMSlotCount < ram.Count())
            {
                Console.WriteLine("\nERROR: number of RAM slots on the motherboard is less than the amount of RAM added to the PC");
                errorHandler("RAM");
            }
        }

        public void drivesAudit()
        {
            for (int i = 0; i < drives.Count(); i++)
            {
                if (drives[i].Interface == "HDD")
                {
                    if (drives[i].Interface != MotherBoard.DriverInterfaceHDD)
                    {
                        Console.WriteLine("\nERROR: driver interface and motherboard driver interface do not match");
                        deleteDrive(i);
                        errorHandler("DRIVE");
                    }
                }
                else if (drives[i].Interface == "SSD")
                {
                    if (drives[i].Interface != MotherBoard.DriverInterfaceSSD)
                    {
                        Console.WriteLine("\nERROR: driver interface and motherboard driver interface do not match");
                        deleteDrive(i);
                        errorHandler("DRIVE");
                    }
                }
            }
        }

        public void outputDetailInfo()
        {
            Console.WriteLine("\nYour PC:" +
                "\n\nRAM:");
            outputRAMInfo();
            Console.WriteLine("\nCPU:" +
                $"\n\tCPU socket: {CPU.Socket};" +
                $"\n\tCPU cores: {CPU.Cores};" +
                $"\n\tCPU threads: {CPU.Threads};" +
                $"\n\tCPU frequency: {CPU.Frequency} GHz;" +
                $"\n\tPrice - {CPU.Price}, supplier - {CPU.Supplier}, country - {CPU.Country}, name - {CPU.Name};" +
                "\nGPU:" +
                $"\n\tGPU type: {GPU.Type};" +
                $"\n\tGPU memory size: {GPU.MemorySize} GB;" +
                $"\n\tGPU memory interface: {GPU.MemoryInterface}-bit;" +
                $"\n\tGPU core clock speed: {GPU.CoreClockSpeed} MGz;" +
                $"\n\tPrice - {GPU.Price}, supplier - {GPU.Supplier}, country - {GPU.Country}, name - {GPU.Name};" +
                "\nMotherboard:" +
                $"\n\tMotherBoard CPU socket: {MotherBoard.Socket}" +
                $"\n\tMotherBoard RAM slot count: {MotherBoard.RAMSlotCount}" +
                $"\n\tMotherBoard driver interface(for HDD): {MotherBoard.DriverInterfaceHDD}" +
                $"\n\tMotherBoard driver interface(for SSD): {MotherBoard.DriverInterfaceSSD}" +
                $"\n\tPrice - {MotherBoard.Price}, supplier - {MotherBoard.Supplier}, country - {MotherBoard.Country}, name - {MotherBoard.Name};" +
                "\nDrive:");
            outputDrivesInfo();
        }

        public void outputRAMInfo()
        {
            for(int i = 0; i < ram.Count(); i++ )
            {
                Console.WriteLine($"\tRAM {i + 1}:" +
                    $"\n\tRAM type: {ram[i].Type};" +
                    $"\n\tRAM size: {ram[i].Size} MB;" +
                    $"\n\tRAM frequency: {ram[i].Frequency} MGz;" +
                    $"\n\tPrice - {ram[i].Price}, supplier - {ram[i].Supplier}, country - {ram[i].Country}, name - {ram[i].Name};\n");
            }
        }

        public void outputDrivesInfo()
        {
            for (int i = 0; i < drives.Count(); i++ )
            {
                if (drives[i].Type == "HDD")
                {
                    Console.WriteLine($"\tDrive {i + 1}:" +
                        $"\n\tDrive type: {drives[i].Type};" +
                        $"\n\tDrive size: {drives[i].Size} GB;" +
                        $"\n\tDrive speed: {drives[i].Speed} RPM;" +
                        $"\n\tDrive interface: {drives[i].Interface};" +
                        $"\n\tPrice - {drives[i].Price}, supplier - {drives[i].Supplier}, country - {drives[i].Country}, name - {drives[i].Name};\n");
                }
                if (drives[i].Type == "SSD")
                {
                    Console.WriteLine($"\tDrive {i + 1}:" +
                        $"\n\tDrive type: {drives[i].Type};" +
                        $"\n\tDrive size: {drives[i].Size} GB;" +
                        $"\n\tDrive speed: {drives[i].Speed} MB/s;" +
                        $"\n\tDrive interface: {drives[i].Interface};" +
                        $"\n\tDrive lifetime: {drives[i].LifeTime};" +
                        $"\n\tPrice - {drives[i].Price}, supplier - {drives[i].Supplier}, country - {drives[i].Country}, name - {drives[i].Name};\n");
                }
            }
        }

        public void errorHandler(string logical)
        {
            if (logical == "CPU")
            {
                Console.WriteLine("\nOverwrite details\nWhat detail do you want to overwrite CPU or Motherboard?");
                string userChoice = Console.ReadLine();

                if (userChoice == "CPU" || userChoice == "cpu" || userChoice == "1")
                {
                    GetCPU();
                }
                else if (userChoice == "Motherboard" || userChoice == "motherboard" || userChoice == "2")
                {
                    GetMotherBoard();
                }
            }
            else if (logical == "RAM")
            {
                Console.WriteLine("\nRemove excess RAM\nEnter RAM number you want to delete");
                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice - 1 > ram.Count())
                {
                    errorHandler("RAM");
                }
                else
                {
                    deleteRAM(userChoice - 1);
                }
            }
            else if (logical == "DRIVE")
            {
                Console.WriteLine("\nOverwrite details\nWhat detail do you want to overwrite Drive or Motherboard?\n");
                string userChoice = Console.ReadLine();

                if (userChoice == "Drive" || userChoice == "drive" || userChoice == "1")
                {
                    GetDrives();
                }
                else if (userChoice == "Motherboard" || userChoice == "motherboard" || userChoice == "2")
                {
                    GetMotherBoard();
                }
            }
        }

        public void deleteRAM(int ramNumber)
        {
            ram.Remove(ram[ramNumber]);
        }

        public void deleteDrive(int driveNumber)
        {
            drives.Remove(drives[driveNumber]);
        }
    }
}