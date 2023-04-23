using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class OpenDirs
    {
        public static void OpenDir(string toOpenDirName)
        {
            var dir = Directory.GetCurrentDirectory();

            var newDir = Path.Combine(dir, toOpenDirName);

            if (Directory.Exists(newDir))
            {
                Directory.SetCurrentDirectory(newDir);
            }
            else
            {
                Console.WriteLine("\n---Error: Directory with this name don't exists---");
            }
        }
    }
}
