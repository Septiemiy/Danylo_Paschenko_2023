using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class GetDirInfo
    {

        private static DirectoryInfo GetInfo(string dirPath)
        {
            if (CheckDirectory(dirPath) == false) return null;

            var dirInfo = new DirectoryInfo(dirPath);
            return dirInfo;
        }

        public static void OutputInfo(string dirPath)
        {
            if (GetInfo(dirPath) != null)
            {
                var dirInfo = GetInfo(dirPath);

                Console.WriteLine(
                    $"\nName:\n\t{dirInfo.Name}\n\n" +
                    $"Creation time:\n\t{dirInfo.CreationTime}\n\n" +
                    $"Last modification time:\n\t{dirInfo.LastWriteTime}\n");
            }
        }

        private static bool CheckDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine("\n---Error: Directory with this name don't exists---");
                return false;
            }
            return true;
        }
    }
}
