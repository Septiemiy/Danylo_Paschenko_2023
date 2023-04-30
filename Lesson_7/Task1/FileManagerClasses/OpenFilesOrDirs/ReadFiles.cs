using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class ReadFiles
    {
        public static void ReadFile(string fileName)
        {
            try
            {
                var text = File.ReadAllText(fileName);
                Console.WriteLine("\n|||||||||");
                Console.WriteLine($"\n{text}");
                Console.WriteLine("\n|||||||||");
            }
            catch
            {
                Console.WriteLine("\n---Error: File with this name don't exists---");
            }
        }
    }
}
